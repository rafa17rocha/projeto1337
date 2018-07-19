using System;
using System.Xml;

namespace EY.Reinf.Object.Model
{
    public class R2010 : EventoReinf2010
    {
        protected override string NomeSchemaEvento
        {
            get { return "evtTomadorServicos"; }
        }

        protected override string NomeTagEvento
        {
            get { return "evtEspDesportivo"; }
        }

        public string tpInscEstab
        {
            get { return _tpInscEstab; }
            set { _tpInscEstab = value; }
        }
        private string _tpInscEstab;

        public string nrInscEstab
        {
            get { return _nrInscEstab; }
            set { _nrInscEstab = value; }
        }
        private string _nrInscEstab;


        public string indObra
        {
            get { return _indObra; }
            set { _indObra = value; }
        }
        private string _indObra;


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

        public string cnpjPrestador
        {
            get { return _cnpjPrestador; }
            set { _cnpjPrestador = value; }
        }
        private string _cnpjPrestador;

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


        public decimal vlrTotalRetAdic
        {
            get { return _vlrTotalRetAdic; }
            set { _vlrTotalRetAdic = value; }
        }
        private decimal _vlrTotalRetAdic;


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

        public string serie
        {
            get { return _serie; }
            set { _serie = value; }
        }
        private string _serie;

        public decimal vlrBruto
        {
            get { return _vlrBruto; }
            set { _vlrBruto = value; }
        }
        private decimal _vlrBruto;


        public string obs
        {
            get { return _obs; }
            set { _obs = value; }
        }
        private string _obs;

        public string numDocto
        {
            get { return _numDocto; }
            set { _numDocto = value; }
        }
        private string _numDocto;

        public DateTime dtEmissaoNF
        {
            get { return _dtEmissaoNF; }
            set { _dtEmissaoNF = value; }
        }
        private DateTime _dtEmissaoNF;


        public string tpServico
        {
            get { return _tpServico; }
            set { _tpServico = value; }
        }
        private string _tpServico;


        public string vlrBaseRet
        {
            get { return _vlrBaseRet; }
            set { _vlrBaseRet = value; }
        }
        private string _vlrBaseRet;

        public string vlrRetencao
        {
            get { return _vlrRetencao; }
            set { _vlrRetencao = value; }
        }
        private string _vlrRetencao;


        public string vlrRetSub
        {
            get { return _vlrRetSub; }
            set { _vlrRetSub = value; }
        }
        private string _vlrRetSub;


        public string vlrNRetPrinc
        {
            get { return _vlrNRetPrinc; }
            set { _vlrNRetPrinc = value; }
        }
        private string _vlrNRetPrinc;

        public string vlrServicos15
        {
            get { return _vlrServicos15; }
            set { _vlrServicos15 = value; }
        }
        private string _vlrServicos15;


        public string vlrServicos20
        {
            get { return _vlrServicos20; }
            set { _vlrServicos20 = value; }
        }
        private string _vlrServicos20;

        public string vlrServicos25
        {
            get { return _vlrServicos25; }
            set { _vlrServicos25 = value; }
        }
        private string _vlrServicos25;

        public string vlrAdicional
        {
            get { return _vlrAdicional; }
            set { _vlrAdicional = value; }
        }
        private string _vlrAdicional;


        public string vlrNRetAdic
        {
            get { return _vlrNRetAdic; }
            set { _vlrNRetAdic = value; }
        }
        private string _vlrNRetAdic;


        public string tpProcRetPrinc
        {
            get { return _tpProcRetPrinc; }
            set { _tpProcRetPrinc = value; }
        }
        private string _tpProcRetPrinc;



        public string nrProcRetPrinc
        {
            get { return _nrProcRetPrinc; }
            set { _nrProcRetPrinc = value; }
        }
        private string _nrProcRetPrinc;


        public string codSuspPrinc
        {
            get { return _codSuspPrinc; }
            set { _codSuspPrinc = value; }
        }
        private string _codSuspPrinc;


        public string valorPrinc
        {
            get { return _valorPrinc; }
            set { _valorPrinc = value; }
        }
        private string _valorPrinc;




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
            XmlElement e = XmlDoc.CreateElement("infoServTom");
            //e.AppendChild(operacao());
            e.AppendChild(ideEstabObra());


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

        private XmlNode ideEstabObra()
        {
            XmlElement e = XmlDoc.CreateElement("ideEstabObra");

            e.AppendChild(CreateElement("tpInscEstab", this.tpInscEstab));
            e.AppendChild(CreateElement("nrInscEstab", this.nrInscEstab));
            e.AppendChild(CreateElement("indObra", this.indObra));
            e.AppendChild(idePrestServ());

            return e;
        }

        private XmlNode idePrestServ()
        {
            XmlElement e = XmlDoc.CreateElement("idePrestServ");
            e.AppendChild(CreateElement("cnpjPrestador", this.cnpjPrestador));
            e.AppendChild(CreateElement("vlrTotalBruto", FormatadorReinf.FormatarMoeda(this.vlrTotalBruto)));
            e.AppendChild(CreateElement("vlrTotalBaseRet", FormatadorReinf.FormatarMoeda(this.vlrTotalBaseRet)));
            e.AppendChild(CreateElement("vlrTotalRetPrinc", FormatadorReinf.FormatarMoeda(this.vlrTotalRetPrinc)));
            e.AppendChild(CreateElement("vlrTotalRetAdic", FormatadorReinf.FormatarMoeda(this.vlrTotalRetAdic)));
            e.AppendChild(CreateElement("vlrTotalNRetPrinc", FormatadorReinf.FormatarMoeda(this.vlrTotalNRetPrinc)));
            e.AppendChild(CreateElement("vlrTotalNRetAdic", FormatadorReinf.FormatarMoeda(this.vlrTotalNRetAdic)));
            e.AppendChild(CreateElement("indCPRB", this.indCPRB));

            e.AppendChild(nfs());
            e.AppendChild(infoProcRetPr());
            e.AppendChild(infoProcRetAd());

            return e;
        }


        private XmlNode infoProcRetPr()
        {
            XmlElement e = XmlDoc.CreateElement("infoProcRetPr");
            e.AppendChild(CreateElement("tpProcRetPrinc", this.tpProcRetPrinc));
            e.AppendChild(CreateElement("nrProcRetPrinc", this.nrProcRetPrinc));

            //Este campo deve ser utilizado se, num mesmo processo
            //e.AppendChild(CreateElement("codSuspPrinc", this.codSuspPrinc));
            e.AppendChild(CreateElement("valorPrinc", this.valorPrinc));

            return e;
        }


        private XmlNode nfs()
        {
            XmlElement e = XmlDoc.CreateElement("nfs");
            e.AppendChild(CreateElement("serie", this.serie));
            e.AppendChild(CreateElement("numDocto", this.numDocto));
            e.AppendChild(CreateElement("dtEmissaoNF", FormatadorReinf.FormatarData(this.dtEmissaoNF)));
            e.AppendChild(CreateElement("vlrBruto", FormatadorReinf.FormatarMoeda(this.vlrBruto)));
            e.AppendChild(CreateElement("obs", this.obs));

            e.AppendChild(infoTpServ());

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
            e.AppendChild(CreateElement("vlrBaseRet", this.vlrBaseRet));
            e.AppendChild(CreateElement("vlrRetencao", this.vlrRetencao));
            e.AppendChild(CreateElement("vlrRetSub", this.vlrRetSub));
            e.AppendChild(CreateElement("vlrNRetPrinc", this.vlrNRetPrinc));
            e.AppendChild(CreateElement("vlrServicos15", this.vlrServicos15));
            e.AppendChild(CreateElement("vlrServicos20", this.vlrServicos20));
            e.AppendChild(CreateElement("vlrServicos25", this.vlrServicos25));
            e.AppendChild(CreateElement("vlrAdicional", this.vlrAdicional));
            e.AppendChild(CreateElement("vlrNRetAdic", this.vlrNRetAdic));

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
