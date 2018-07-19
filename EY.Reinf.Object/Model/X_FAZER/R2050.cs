using System;
using System.Xml;

namespace EY.Reinf.Object.Model
{
    public class R2050 : EventoReinf2050
    {
        protected override string NomeSchemaEvento
        {
            get { return "evtInfoProdRural"; }
        }

        protected override string NomeTagEvento
        {
            get { return "evtComProd"; }
        }

        public string tpInscEstab
        {
            get { return _tpInscEstab; }
            set { _tpInscEstab = value; }
        }
        private string _tpInscEstab;

        public string tpInsc
        {
            get { return _tpInsc; }
            set { _tpInsc = value; }
        }
        private string _tpInsc;

        public string nrInscEstab
        {
            get { return _nrInscEstab; }
            set { _nrInscEstab = value; }
        }
        private string _nrInscEstab;

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

        public string cnpjAssocDesp
        {
            get { return _cnpjAssocDesp; }
            set { _cnpjAssocDesp = value; }
        }
        private string _cnpjAssocDesp;


        public decimal vlrCPApur
        {
            get { return _vlrCPApur; }
            set { _vlrCPApur = value; }
        }
        private decimal _vlrCPApur;



        public decimal vlrRatApur
        {
            get { return _vlrRatApur; }
            set { _vlrRatApur = value; }
        }
        private decimal _vlrRatApur;


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

        public decimal vlrRecBrutaTotal
        {
            get { return _vlrRecBrutaTotal; }
            set { _vlrRecBrutaTotal = value; }
        }
        private decimal _vlrRecBrutaTotal;

        public decimal vlrTotalRep
        {
            get { return _vlrTotalRep; }
            set { _vlrTotalRep = value; }
        }
        private decimal _vlrTotalRep;


        public decimal vlrTotalRet
        {
            get { return _vlrTotalRet; }
            set { _vlrTotalRet = value; }
        }

        private decimal _vlrTotalRet;

        public decimal vlrTotalNRet
        {
            get { return _vlrTotalNRet; }
            set { _vlrTotalNRet = value; }
        }
        private decimal _vlrTotalNRet;


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

        public string indCom
        {
            get { return _indCom; }
            set { _indCom = value; }
        }
        private string _indCom;

        public decimal vlrRecBruta
        {
            get { return _vlrRecBruta; }
            set { _vlrRecBruta = value; }
        }
        private decimal _vlrRecBruta;


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


        public decimal vlrBaseRet
        {
            get { return _vlrBaseRet; }
            set { _vlrBaseRet = value; }
        }
        private decimal _vlrBaseRet;

        public string vlrRetencao
        {
            get { return _vlrRetencao; }
            set { _vlrRetencao = value; }
        }
        private string _vlrRetencao;


        public decimal vlrRetSub
        {
            get { return _vlrRetSub; }
            set { _vlrRetSub = value; }
        }
        private decimal _vlrRetSub;


        public string vlrNRetPrinc
        {
            get { return _vlrNRetPrinc; }
            set { _vlrNRetPrinc = value; }
        }
        private string _vlrNRetPrinc;

        public decimal vlrServicos15
        {
            get { return _vlrServicos15; }
            set { _vlrServicos15 = value; }
        }
        private decimal _vlrServicos15;


        public decimal vlrServicos20
        {
            get { return _vlrServicos20; }
            set { _vlrServicos20 = value; }
        }
        private decimal _vlrServicos20;

        public decimal vlrServicos25
        {
            get { return _vlrServicos25; }
            set { _vlrServicos25 = value; }
        }
        private decimal _vlrServicos25;

        public decimal vlrAdicional
        {
            get { return _vlrAdicional; }
            set { _vlrAdicional = value; }
        }
        private decimal _vlrAdicional;


        public decimal vlrNRetAdic
        {
            get { return _vlrNRetAdic; }
            set { _vlrNRetAdic = value; }
        }
        private decimal _vlrNRetAdic;


        public string tpProc
        {
            get { return _tpProc; }
            set { _tpProc = value; }
        }
        private string _tpProc;



        public string nrProc
        {
            get { return _nrProc; }
            set { _nrProc = value; }
        }
        private string _nrProc;


        public string codSusp
        {
            get { return _codSusp; }
            set { _codSusp = value; }
        }
        private string _codSusp;

        public decimal vlrSenarSusp
        {
            get { return _vlrSenarSusp; }
            set { _vlrSenarSusp = value; }
        }
        private decimal _vlrSenarSusp;


        public decimal vlrCPSusp
        {
            get { return _vlrCPSusp; }
            set { _vlrCPSusp = value; }
        }
        private decimal _vlrCPSusp;

        public decimal vlrRatSusp
        {
            get { return _vlrRatSusp; }
            set { _vlrRatSusp = value; }
        }
        private decimal _vlrRatSusp;


        public string tpProcRetAdic
        {
            get { return _tpProcRetAdic; }
            set { _tpProcRetAdic = value; }
        }
        private string _tpProcRetAdic;


        public string nrProcRetAdic
        {
            get { return _nrProcRetAdic; }
            set { _nrProcRetAdic = value; }
        }
        private string _nrProcRetAdic;

        public string codSuspAdic
        {
            get { return _codSuspAdic; }
            set { _codSuspAdic = value; }
        }
        private string _codSuspAdic;

        public string valorAdic
        {
            get { return _valorAdic; }
            set { _valorAdic = value; }
        }
        private string _valorAdic;

        protected override XmlNode info()
        {
            XmlElement e = XmlDoc.CreateElement("infoComProd");
            e.AppendChild(ideEstab());

            return e;

            //switch (this.Operacao)
            //{
            //    case Enumeracoes.OperacoesREINF.INCLUSAO:
            //        e.AppendChild(infoCadastro());
            //        break;
            //    case Enumeracoes.OperacoesREINF.ALTERACAO:
            //        e.AppendChild(infoCadastro());
            //        break;
            //    case Enumeracoes.OperacoesREINF.EXCLUSAO:
            //        e.AppendChild(infoCadastro());
            //        break;
            //    default:
            //        throw new InvalidOperationException(this.Operacao.ToString());
            //}
        }

        //private XmlNode operacao()
        //{
        //    XmlElement e = XmlDoc.CreateElement(this.Operacao.ToString().ToLower());
        //    e.AppendChild(ideEstabObra());
        //    if (this.Operacao != Enumeracoes.OperacoesREINF.EXCLUSAO)
        //    {
        //        e.AppendChild(idePrestServ());
        //        if (this.Operacao == Enumeracoes.OperacoesREINF.ALTERACAO)
        //            e.AppendChild(novaValidade());
        //    }
        //    return e;
        //}

        private XmlNode ideEstab()
        {
            XmlElement e = XmlDoc.CreateElement("ideEstab");
            e.AppendChild(CreateElement("tpInscEstab", this.tpInscEstab));
            e.AppendChild(CreateElement("nrInscEstab", this.nrInscEstab));
            e.AppendChild(CreateElement("vlrRecBrutaTotal", FormatadorReinf.FormatarMoeda(this.vlrRecBrutaTotal)));
            e.AppendChild(CreateElement("vlrCPApur", FormatadorReinf.FormatarMoeda(this.vlrCPApur)));
            e.AppendChild(CreateElement("vlrRatApur", FormatadorReinf.FormatarMoeda(this.vlrRatApur)));
            e.AppendChild(CreateElement("vlrSenarApur", FormatadorReinf.FormatarMoeda(this.vlrSenarApur)));
            e.AppendChild(CreateElement("vlrCPSuspTotal", FormatadorReinf.FormatarMoeda(this.vlrCPSuspTotal)));
            e.AppendChild(CreateElement("vlrRatSuspTotal", FormatadorReinf.FormatarMoeda(this.vlrRatSuspTotal)));
            e.AppendChild(CreateElement("vlrSenarSuspTotal", FormatadorReinf.FormatarMoeda(this.vlrSenarSuspTotal)));
            e.AppendChild(tipoCom());
            return e;
        }

        private XmlNode recursosRep()
        {
            XmlElement e = XmlDoc.CreateElement("recursosRep");
            e.AppendChild(CreateElement("cnpjAssocDesp", this.cnpjAssocDesp));
            e.AppendChild(CreateElement("vlrTotalRep", FormatadorReinf.FormatarMoeda(this.vlrTotalRep)));
            e.AppendChild(CreateElement("vlrTotalRet", FormatadorReinf.FormatarMoeda(this.vlrTotalRet)));
            e.AppendChild(CreateElement("vlrTotalNRet", FormatadorReinf.FormatarMoeda(this.vlrTotalNRet)));
            e.AppendChild(infoProc());
            return e;
        }

        private XmlNode infoProc()
        {
            XmlElement e = XmlDoc.CreateElement("infoProc");
            e.AppendChild(CreateElement("tpProc", this.tpProc));
            e.AppendChild(CreateElement("nrProc", this.nrProc));
            //Este campo deve ser utilizado se, num mesmo processo
            //e.AppendChild(CreateElement("codSusp", this.codSusp));
            e.AppendChild(CreateElement("vlrCPSusp", FormatadorReinf.FormatarMoeda(this.vlrCPSusp)));
            e.AppendChild(CreateElement("vlrRatSusp", FormatadorReinf.FormatarMoeda(this.vlrRatSusp)));
            e.AppendChild(CreateElement("vlrSenarSusp", FormatadorReinf.FormatarMoeda(this.vlrSenarSusp)));

            return e;
        }

        private XmlNode tipoCom()
        {
            XmlElement e = XmlDoc.CreateElement("tipoCom");

            e.AppendChild(CreateElement("indCom", this.indCom));
            e.AppendChild(CreateElement("vlrRecBruta", FormatadorReinf.FormatarMoeda(this.vlrRecBruta)));
            e.AppendChild(infoProc());

            return e;
        }

        private XmlNode infoProcRetAd()
        {
            XmlElement e = XmlDoc.CreateElement("infoProcRetAd");
            e.AppendChild(CreateElement("tpProcRetAdic", this.tpProcRetAdic));
            e.AppendChild(CreateElement("nrProcRetAdic", this.nrProcRetAdic));
            e.AppendChild(CreateElement("codSuspAdic", this.codSuspAdic));
            e.AppendChild(CreateElement("valorAdic", this.valorAdic));
            return e;
        }

        private XmlNode infoTpServ()
        {
            XmlElement e = XmlDoc.CreateElement("infoTpServ");
            e.AppendChild(CreateElement("tpServico", this.tpServico));
            e.AppendChild(CreateElement("vlrBaseRet", FormatadorReinf.FormatarMoeda(this.vlrBaseRet)));
            e.AppendChild(CreateElement("vlrRetencao", this.vlrRetencao));
            e.AppendChild(CreateElement("vlrRetSub", FormatadorReinf.FormatarMoeda(this.vlrRetSub)));
            e.AppendChild(CreateElement("vlrNRetPrinc", this.vlrNRetPrinc));
            e.AppendChild(CreateElement("vlrServicos15", FormatadorReinf.FormatarMoeda(this.vlrServicos15)));
            e.AppendChild(CreateElement("vlrServicos20", FormatadorReinf.FormatarMoeda(this.vlrServicos20)));
            e.AppendChild(CreateElement("vlrServicos25", FormatadorReinf.FormatarMoeda(this.vlrServicos25)));
            e.AppendChild(CreateElement("vlrAdicional", FormatadorReinf.FormatarMoeda(this.vlrAdicional)));
            e.AppendChild(CreateElement("vlrNRetAdic", FormatadorReinf.FormatarMoeda(this.vlrNRetAdic)));

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
