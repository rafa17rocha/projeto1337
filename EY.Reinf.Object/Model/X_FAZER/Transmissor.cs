using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace EY.Reinf.Object.Model
{
    public class Transmissor
    {
        public X509Certificate2 Certificado
        {
            get { return _certificado; }
            set { _certificado = value; }
        }
        private X509Certificate2 _certificado;

        public string URL
        {
            get { return _url; }
            set { _url = value; }
        }
        //private string _url = @"https://reinf.receita.fazenda.gov.br/WsREINF/RecepcaoLoteReinf.svc";
        private string _url = @"https://preprodefdreinf.receita.fazenda.gov.br/WsREINF/RecepcaoLoteReinf.svc";


        public int TimeOutEmSegundos
        {
            get { return _timeOutEmSegundos; }
            set { _timeOutEmSegundos = value; }
        }

        private int _timeOutEmSegundos = 900;

        public string UltimaRequisicao { get; private set; }

        private Dictionary<string, XmlDocument> EventosAssinados
        {
            get { return _eventosAssinados; }
        }
        private Dictionary<string, XmlDocument> _eventosAssinados = new Dictionary<string, XmlDocument>();

        public void AdicionarEventoAssinado(string idEvento, XmlDocument xmlAssinadoEvento)
        {
            this.EventosAssinados.Add(idEvento, xmlAssinadoEvento);
        }


        public string MontarXmlRequisicao()
        {
            string xmlRequisicaoSOAP =
        @"<?xml version=""1.0"" encoding=""utf-8""?>
        <soap:Envelope 
	        xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" 
	        xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" 
	        xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/""
	        xmlns:sped=""http://sped.fazenda.gov.br/"">
        <soap:Header></soap:Header>
        <soap:Body>
	        <sped:ReceberLoteEventos>
	        <sped:loteEventos>
	        <Reinf xmlns=""http://www.reinf.esocial.gov.br/schemas/envioLoteEventos/v1_03_02"">
		        {0}
	        </Reinf>
	        </sped:loteEventos>
	        </sped:ReceberLoteEventos>
        </soap:Body>
        </soap:Envelope>";

            XmlNode xmlLote = MontarLote();
            xmlRequisicaoSOAP = string.Format(xmlRequisicaoSOAP, xmlLote.FirstChild.OuterXml);
            return xmlRequisicaoSOAP;
        }

        private XmlDocument MontarLote()
        {
            if(this.EventosAssinados.Count == 0)
                throw new InvalidOperationException("sem eventos para lote");

            XmlDocument xmlEventos = new XmlDocument();
            xmlEventos.PreserveWhitespace = false;

            XmlNode elementLoteEventos = xmlEventos.CreateElement("loteEventos");

            foreach(KeyValuePair<string, XmlDocument> ev in this.EventosAssinados)
            {
                XmlNode elementEvento = xmlEventos.CreateElement("evento");

                XmlAttribute attId = xmlEventos.CreateAttribute("id");
                attId.Value = ev.Key; // ev.Key.Substring(0, ev.Key.Length - 1) + "1"; //TODO ev.Key;
                elementEvento.Attributes.Append(attId);

                XmlNode importing = elementEvento.OwnerDocument.ImportNode(ev.Value.FirstChild is XmlDeclaration
                    ? ev.Value.ChildNodes[1].Clone()
                    : ev.Value.FirstChild.Clone(), true);
                elementEvento.AppendChild(importing);

                elementLoteEventos.AppendChild(elementEvento);
            }

            xmlEventos.AppendChild(elementLoteEventos);

            return xmlEventos;
        }

        public string Transmitir()
        {
            string xmlRequisicaoSOAP = MontarXmlRequisicao();

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.URL);
            //request.Headers.Add("SOAPAction", string.Format("\"{0}{1}\"", XMLNS, METODO));
            request.Headers.Add("SOAPAction", @"http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventos");
            request.ContentType = "text/xml;charset=\"utf-8\"";
            request.Accept = "text/xml";
            request.Method = "POST";

            if(this.Certificado != null)
                request.ClientCertificates.Add(this.Certificado);
            if(this.TimeOutEmSegundos > 0)
                request.Timeout = this.TimeOutEmSegundos * 1000;

            this.UltimaRequisicao = xmlRequisicaoSOAP;

            using(Stream stream = request.GetRequestStream())
            {
                using(StreamWriter stmw = new StreamWriter(stream))
                {
                    stmw.Write(xmlRequisicaoSOAP);
                }
            }

            try
            {
                WebResponse webresponse = request.GetResponse();
                HttpWebResponse response = (HttpWebResponse) webresponse;
                //if(response.StatusCode == HttpStatusCode.OK)
                using(StreamReader responseReader = new StreamReader(response.GetResponseStream()))
                {
                    string result = responseReader.ReadToEnd();
                    return result;
                }
            }
            catch(WebException wex)
            {
                string mensagemSubjacente = ObterMensagemSubjacente(wex);
                string msg = string.Format("{1}{0}Detalhes subjacentes: {2}",
                    System.Environment.NewLine, wex.Message, mensagemSubjacente);
                throw new ExcecaoComunicacaoReinf(msg, wex, xmlRequisicaoSOAP);
            }
            catch(Exception ex)
            {
                throw new ExcecaoComunicacaoReinf(ex.Message, ex, xmlRequisicaoSOAP);
            }
        }

        private static string ObterMensagemSubjacente(WebException wex)
        {
            //TODO rever
            if(wex.Response == null)
                return wex.Message;

            string mensagemSubjacente = string.Empty;
            using(Stream s = wex.Response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s);
                mensagemSubjacente = reader.ReadToEnd();

                try
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(mensagemSubjacente);
                    XmlNodeList fault = xml.GetElementsByTagName("faultstring");
                    if(fault != null && fault.Count > 0)
                    {
                        mensagemSubjacente = fault[0].InnerText;
                    }
                }
                catch
                {
                }
            }
            return mensagemSubjacente;
        }
    }
}
