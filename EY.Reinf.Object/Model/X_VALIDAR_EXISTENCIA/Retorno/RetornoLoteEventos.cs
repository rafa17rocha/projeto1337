using System;
using System.Collections.Generic;
using System.Xml;

namespace EY.Reinf.Object.Model.VALIDAR.Retorno
{
    public class RetornoLoteEventos
    {
        public XmlNode Xml
        {
            get { return _xml; }
            set { _xml = value; }
        }
        private XmlNode _xml;

        public string IdTransmissor
        {
            get { return _idTransmissor; }
            set { _idTransmissor = value; }
        }
        private string _idTransmissor;

        public string IdLoteTransmitido
        {
            get { return _idLoteTransmitido; }
            set { _idLoteTransmitido = value; }
        }
        private string _idLoteTransmitido;

        public string IdRetornoLote
        {
            get { return _idRetornoLote; }
            private set { _idRetornoLote = value; }
        }
        private string _idRetornoLote;

        public StatusRetorno StatusLote
        {
            get { return _statusLote; }
            private set { _statusLote = value; }
        }
        private StatusRetorno _statusLote = null;

        public bool SucessoRecepcaoLote
        {
            get
            {
                return this.StatusLote.Codigo == "0";
            }
        }

        public bool SucessoTodosEventos
        {
            get
            {
                foreach(RetornoEvento r in this.RetornosEventos)
                    if(!r.SucessoEvento)
                        return false;
                return true;
            }
        }

        public List<RetornoEvento> RetornosEventos
        {
            get { return _retornosEventos; }
        }
        private List<RetornoEvento> _retornosEventos = new List<RetornoEvento>();

        private XmlNamespaceManager nsmgr;

        public RetornoLoteEventos(XmlDocument xml)
        {
            if(xml == null)
                throw new ArgumentNullException();

            this.Xml = xml;

            this.nsmgr = new XmlNamespaceManager(xml.NameTable);
            this.nsmgr.AddNamespace("L", "http://www.reinf.esocial.gov.br/schemas/envioLoteEventos/v1_03_02");
            this.nsmgr.AddNamespace("E", "http://www.reinf.esocial.gov.br/schemas/envioLoteEventos/v1_03_02");

            Parse();
        }

        private void Parse()
        {
            this.IdRetornoLote = GetAttribute("//L:retornoLoteEventos/@id");
            this.IdTransmissor = GetInnerText("//L:retornoLoteEventos/L:ideTransmissor/L:IdTransmissor");
            this.IdLoteTransmitido = GetAttribute("//L:retornoLoteEventos/L:retornoEventos/L:evento/@id");
            this.StatusLote = new StatusRetorno();
            this.StatusLote.Codigo = GetInnerText("//L:retornoLoteEventos/L:status/L:cdStatus");
            this.StatusLote.Descricao = GetInnerText("//L:retornoLoteEventos/L:status/L:descRetorno");

            this.RetornosEventos.AddRange(ParseEventos());
        }

        private List<RetornoEvento> ParseEventos()
        {
            List<RetornoEvento> retornosEventos = new List<RetornoEvento>();
            XmlNodeList nodesEventos = this.Xml.SelectNodes("//L:retornoLoteEventos/L:retornoEventos/L:evento", this.nsmgr);
            foreach(XmlNode e in nodesEventos)
            {
                RetornoEvento r = new RetornoEvento();
                r.Status = new StatusRetorno();
                r.Status.Codigo = GetInnerText(e, "./E:Reinf/E:retornoEvento/E:status/E:cdRetorno");
                r.Status.Descricao = GetInnerText(e, "./E:Reinf/E:retornoEvento/E:status/E:descRetorno");
                r.IdEventoTransmitido = GetInnerText(e, "./E:Reinf/E:retornoEvento/E:dadosRecepcaoEvento/E:idEvento");
                r.IdRetornoEvento = GetAttribute(e, "./E:Reinf/E:retornoEvento/@id");
                r.NumeroInscricaoContribuinte = GetInnerText(e, "./E:Reinf/E:retornoEvento/E:ideContrib/E:nrInsc");
                r.RawDataHoraProcessamento = GetInnerText(e, "./E:Reinf/E:retornoEvento/E:dadosRecepcaoEvento/E:dhProcessamento");
                r.Tipo = GetInnerText(e, "./E:Reinf/E:retornoEvento/E:dadosRecepcaoEvento/E:tipoEvento");

                if(r.SucessoEvento)
                {
                    r.NumeroRecibo = GetInnerText(e, "./E:Reinf/E:retornoEvento/E:dadosReciboEntrega/E:numeroRecibo");
                }
                else
                {
                    r.Ocorrencias.AddRange(ParseOcorrencias(e));
                }

                retornosEventos.Add(r);
            }
            return retornosEventos;
        }

        private List<Ocorrencia> ParseOcorrencias(XmlNode nodeEvento)
        {
            List<Ocorrencia> ocorrencias = new List<Ocorrencia>();
            XmlNodeList nodesOcorrencias = nodeEvento.SelectNodes("./E:Reinf/E:retornoEvento/E:status/E:dadosRegistroOcorrenciaEvento/E:ocorrencias", this.nsmgr);
            foreach(XmlNode nodeOcorrencia in nodesOcorrencias)
            {
                Ocorrencia ocorrencia = new Ocorrencia();
                ocorrencia.Localizacao = GetInnerText(nodeOcorrencia, "./E:localizacaoErroAviso");
                ocorrencia.Codigo = GetInnerText(nodeOcorrencia, "./E:codigo");
                ocorrencia.Descricao = GetInnerText(nodeOcorrencia, "./E:descricao");
                ocorrencias.Add(ocorrencia);
            }
            return ocorrencias;
        }

        private string GetInnerText(string xpath)
        {
            return GetInnerText(this.Xml, xpath);
        }

        private string GetInnerText(XmlNode node, string xpath)
        {
            XmlNode subnode = node.SelectSingleNode(xpath, this.nsmgr);
            if(subnode != null)
                return subnode.InnerText;
            else
                throw new InvalidOperationException("Não encontrado: " + xpath);
        }

        private string GetAttribute(string xpath)
        {
            return GetAttribute(this.Xml, xpath);
        }

        private string GetAttribute(XmlNode node, string xpath)
        {
            XmlNode subnode = node.SelectSingleNode(xpath, this.nsmgr);
            if(subnode != null)
                return subnode.Value;
            else
                throw new InvalidOperationException("Não encontrado: " + xpath);
        }
    }
}
