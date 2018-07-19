using System;
using System.Xml;



namespace EY.Reinf.Object.Model
{
    public abstract class EventoReinf2020
    {
        protected XmlDocument XmlDoc
        {
            get { return _xmlDoc; }
        }
        private readonly XmlDocument _xmlDoc = new XmlDocument();

        public string indRetif
        {
            get { return _indRetif; }
            set { _indRetif = value; }
        }
        private string _indRetif;

        public string nrRecibo
        {
            get { return _nrRecibo; }
            set { _nrRecibo = value; }
        }
        private string _nrRecibo;

        public DateTime perApur
        {
            get { return _perApur; }
            set { _perApur = value; }
        }
        private DateTime _perApur;

        public Enumeracoes.Ambientes Ambiente
        {
            get { return _ambiente; }
            set { _ambiente = value; }
        }
        private Enumeracoes.Ambientes _ambiente;

        public string VersaoProcesso
        {
            get { return _versaoProcesso; }
            set { _versaoProcesso = value; }
        }
        private string _versaoProcesso;

        public Enumeracoes.TiposInscricoes TipoInscricao
        {
            get { return _tipoInscricao; }
            set { _tipoInscricao = value; }
        }
        private Enumeracoes.TiposInscricoes _tipoInscricao;

        public string NumeroInscricao
        {
            get { return _numeroInscricao; }
            set { _numeroInscricao = value; }
        }
        private string _numeroInscricao;

        public DateTime DataHoraGeracaoEvento
        {
            get { return _dataHoraGeracaoEvento; }
            set { _dataHoraGeracaoEvento = value; }
        }
        private DateTime _dataHoraGeracaoEvento;

        public int SequencialExtra
        {
            get { return _sequencialExtra; }
            set { _sequencialExtra = value; }
        }
        private int _sequencialExtra;

        public Enumeracoes.OperacoesReinf Operacao
        {
            get { return _operacao; }
            set { _operacao = value; }
        }
        private Enumeracoes.OperacoesReinf _operacao;

        protected const string APLICATIVO_DO_CONTRIBUINTE = "1";

        protected abstract string NomeSchemaEvento { get; }

        protected virtual string VersaoSchemaEvento { get { return "1_03_02"; } }
        protected abstract string NomeTagEvento { get; }

        public string GerarId()
        {
            if(string.IsNullOrEmpty(NumeroInscricao))
                throw new InvalidOperationException();

            return string.Format("ID{0}{1}{2}{3}",
                (int) TipoInscricao,
                System.Text.RegularExpressions.Regex.Replace(NumeroInscricao, "[^0-9]", "").PadRight(14, '0'),
                DataHoraGeracaoEvento.ToString("yyyyMMddHHmmss"),
                SequencialExtra.ToString().PadLeft(5, '0'));
        }

        public XmlDocument GerarXml()
        {
            this.XmlDoc.RemoveAll();
            XmlDoc.PreserveWhitespace = false;
            XmlDoc.AppendChild(XmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
            XmlDoc.AppendChild(Reinf());
            return XmlDoc;
        }

        protected virtual XmlElement Reinf()
        {
            XmlAttribute xmlns = XmlDoc.CreateAttribute("xmlns");
            xmlns.Value = string.Format("http://www.reinf.esocial.gov.br/schemas/{0}/v{1}", this.NomeSchemaEvento, this.VersaoSchemaEvento);

            XmlElement elementReinf = XmlDoc.CreateElement("Reinf");
            elementReinf.Attributes.Append(xmlns);
            elementReinf.AppendChild(evento());
            return elementReinf;
        }

        protected virtual XmlNode evento()
        {
            XmlAttribute attributeId = XmlDoc.CreateAttribute("id");
            attributeId.Value = GerarId();

            XmlElement e = XmlDoc.CreateElement(this.NomeTagEvento);
            e.Attributes.Append(attributeId);
            e.AppendChild(ideEvento());
            e.AppendChild(ideContri());

            XmlNode childInfo = info();
            if(childInfo != null)
                e.AppendChild(childInfo);

            return e;
        }

        protected virtual XmlNode ideEvento()
        {
            XmlElement e = XmlDoc.CreateElement("ideEvento");

            e.AppendChild(CreateElement("indRetif", this.indRetif));

            //Preencher com o número do recibo do arquivo a ser retificado.
            //Validação: O preenchimento é obrigatório se { indRetif } = [2]
            //e.AppendChild(CreateElement("nrRecibo", this.nrRecibo));

            e.AppendChild(CreateElement("perApur", FormatadorReinf.FormatarMesAno(this.perApur)));
            e.AppendChild(CreateElement("tpAmb", ((int) this.Ambiente).ToString()));
            e.AppendChild(CreateElement("procEmi", APLICATIVO_DO_CONTRIBUINTE));
            e.AppendChild(CreateElement("verProc", this.VersaoProcesso));

            return e;
        }

        protected virtual XmlNode ideContri()
        {
            XmlElement e = XmlDoc.CreateElement("ideContri");
            e.AppendChild(CreateElement("tpInsc", ((int) this.TipoInscricao).ToString()));
            e.AppendChild(CreateElement("nrInsc", FormatadorReinf.FormatarCPFCNPJCNO(this.NumeroInscricao)));
            return e;
        }

        protected abstract XmlNode info();

        protected XmlElement CreateElement(string tagName, string innerText)
        {
            XmlElement element = this.XmlDoc.CreateElement(tagName);
            element.InnerText = FormatadorReinf.FormatarGenerico(innerText);
            return element;
        }
    }
}
