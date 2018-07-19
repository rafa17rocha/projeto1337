using System;
using System.Xml;

namespace EY.Reinf.Object.Model
{
    public class R2099 : EventoReinf2099
    {
        protected override string NomeSchemaEvento
        {
            get { return "evtFechamento"; }
        }

        protected override string NomeTagEvento
        {
            get { return "evtFechaEvPer"; }
        }

        public string nmResp
        {
            get { return _nmResp; }
            set { _nmResp = value; }
        }
        private string _nmResp;

        public string tpInsc
        {
            get { return _tpInsc; }
            set { _tpInsc = value; }
        }
        private string _tpInsc;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _email;

        public string cpfResp
        {
            get { return _cpfResp; }
            set { _cpfResp = value; }
        }
        private string _cpfResp;

        public string telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        private string _telefone;

        public DateTime NovoMesAnoInicioValidade
        {
            get { return _novoMesAnoInicioValidade; }
            set { _novoMesAnoInicioValidade = value; }
        }
        private DateTime _novoMesAnoInicioValidade;

        public DateTime NovoMesAnoFimValidade
        {
            get { return _novoMesAnoFimValidade; }
            set { _novoMesAnoFimValidade = value; }
        }
        private DateTime _novoMesAnoFimValidade;

        public string evtServTm
        {
            get { return _evtServTm; }
            set { _evtServTm = value; }
        }
        private string _evtServTm;

        public decimal vlrSenarApur
        {
            get { return _vlrSenarApur; }
            set { _vlrSenarApur = value; }
        }
        private decimal _vlrSenarApur;



        public decimal vlrRatSuspTotal
        {
            get { return _vlrRatSuspTotal; }
            set { _vlrRatSuspTotal = value; }
        }
        private decimal _vlrRatSuspTotal;


        public decimal vlrSenarSuspTotal
        {
            get { return _vlrSenarSuspTotal; }
            set { _vlrSenarSuspTotal = value; }
        }
        private decimal _vlrSenarSuspTotal;


        public decimal vlrCPSuspTotal
        {
            get { return _vlrCPSuspTotal; }
            set { _vlrCPSuspTotal = value; }
        }
        private decimal _vlrCPSuspTotal;



        public string evtServPr
        {
            get { return _evtServPr; }
            set { _evtServPr = value; }
        }
        private string _evtServPr;


        public string evtAssDespRec
        {
            get { return _evtAssDespRec; }
            set { _evtAssDespRec = value; }
        }
        private string _evtAssDespRec;

        public string evtAssDespRep
        {
            get { return _evtAssDespRep; }
            set { _evtAssDespRep = value; }
        }
        private string _evtAssDespRep;


        public decimal vlrTotalRetAdic
        {
            get { return _vlrTotalRetAdic; }
            set { _vlrTotalRetAdic = value; }
        }
        private decimal _vlrTotalRetAdic;

        public decimal vlrTotalBruto
        {
            get { return _vlrTotalBruto; }
            set { _vlrTotalBruto = value; }
        }
        private decimal _vlrTotalBruto;


        public decimal vlrTotalBaseRet
        {
            get { return _vlrTotalBaseRet; }
            set { _vlrTotalBaseRet = value; }
        }
        private decimal _vlrTotalBaseRet;


        public decimal vlrTotalRetPrinc
        {
            get { return _vlrTotalRetPrinc; }
            set { _vlrTotalRetPrinc = value; }
        }
        private decimal _vlrTotalRetPrinc;


        public decimal vlrTotalNRetPrinc
        {
            get { return _vlrTotalNRetPrinc; }
            set { _vlrTotalNRetPrinc = value; }
        }
        private decimal _vlrTotalNRetPrinc;

        public decimal vlrTotalNRetAdic
        {
            get { return _vlrTotalNRetAdic; }
            set { _vlrTotalNRetAdic = value; }
        }
        private decimal _vlrTotalNRetAdic;


        public string indCPRB
        {
            get { return _indCPRB; }
            set { _indCPRB = value; }
        }
        private string _indCPRB;

        public Enumeracoes.IndicativosSituacoesPJ SituacaoPJ
        {
            get { return _situacaoPJ; }
            set { _situacaoPJ = value; }
        }
        private Enumeracoes.IndicativosSituacoesPJ _situacaoPJ;

        public string evtComProd
        {
            get { return _evtComProd; }
            set { _evtComProd = value; }
        }
        private string _evtComProd;

        public string evtCPRB
        {
            get { return _evtCPRB; }
            set { _evtCPRB = value; }
        }
        private string _evtCPRB;

        public string evtPgtos
        {
            get { return _evtPgtos; }
            set { _evtPgtos = value; }
        }
        private string _evtPgtos;

        public DateTime compSemMovto
        {
            get { return _compSemMovto; }
            set { _compSemMovto = value; }
        }
        private DateTime _compSemMovto;

        public decimal vlrRetApur
        {
            get { return _vlrRetApur; }
            set { _vlrRetApur = value; }
        }
        private decimal _vlrRetApur;

        public string obs
        {
            get { return _obs; }
            set { _obs = value; }
        }
        private string _obs;

        public string descRecurso
        {
            get { return _descRecurso; }
            set { _descRecurso = value; }
        }
        private string _descRecurso;

        public string tpServico
        {
            get { return _tpServico; }
            set { _tpServico = value; }
        }
        private string _tpServico;

        public string codSusp
        {
            get { return _codSusp; }
            set { _codSusp = value; }
        }
        private string _codSusp;

        protected override XmlNode ideRespInf()
        {
            XmlElement e = XmlDoc.CreateElement("ideRespInf");
            e.AppendChild(CreateElement("nmResp", this.nmResp));
            e.AppendChild(CreateElement("cpfResp", this.cpfResp));
            e.AppendChild(CreateElement("telefone", this.telefone));
            e.AppendChild(CreateElement("email", this.email));
            return e;
        }

        protected override XmlNode infoFech()
        {
            XmlElement e = XmlDoc.CreateElement("infoFech");

            e.AppendChild(CreateElement("evtServTm", this.evtServTm));
            e.AppendChild(CreateElement("evtServPr", this.evtServPr));
            e.AppendChild(CreateElement("evtAssDespRec", this.evtAssDespRec));
            e.AppendChild(CreateElement("evtAssDespRep", this.evtAssDespRep));
            e.AppendChild(CreateElement("evtComProd", this.evtComProd));
            e.AppendChild(CreateElement("evtCPRB", this.evtCPRB));
            e.AppendChild(CreateElement("evtPgtos", this.evtPgtos));
            e.AppendChild(CreateElement("compSemMovto", FormatadorReinf.FormatarMesAno(this.compSemMovto)));

            return e;
        }

        private XmlNode novaValidade()
        {
            XmlElement e = XmlDoc.CreateElement("novaValidade");
            e.AppendChild(CreateElement("iniValid", FormatadorReinf.FormatarMesAno(this.NovoMesAnoInicioValidade)));
            if(this.NovoMesAnoFimValidade > DateTime.MinValue)
                e.AppendChild(CreateElement("fimValid", FormatadorReinf.FormatarMesAno(this.NovoMesAnoFimValidade)));
            return e;
        }
    }
}
