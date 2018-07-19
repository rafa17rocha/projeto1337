using System.Xml;

namespace EY.Reinf.Object.Model
{
    public class R3010 : EventoReinf3010
    {
        protected override string NomeSchemaEvento
        {
            get { return "evtEspDesportivo"; }
        }

        protected override string NomeTagEvento
        {
            get { return "evtEspDesportivo"; }
        }


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

        public decimal vlrCPSusp
        {
            get { return _vlrCPSusp; }
            set { _vlrCPSusp = value; }
        }
        private decimal _vlrCPSusp;

        public string descReceita
        {
            get { return _descReceita; }
            set { _descReceita = value; }
        }
        private string _descReceita;

        public decimal vlrReceita
        {
            get { return _vlrReceita; }
            set { _vlrReceita = value; }
        }
        private decimal _vlrReceita;



        public decimal vlrRetParc
        {
            get { return _vlrRetParc; }
            set { _vlrRetParc = value; }
        }
        private decimal _vlrRetParc;


        public decimal vlrReceitaClubes
        {
            get { return _vlrReceitaClubes; }
            set { _vlrReceitaClubes = value; }
        }
        private decimal _vlrReceitaClubes;


        public decimal vlrCP
        {
            get { return _vlrCP; }
            set { _vlrCP = value; }
        }
        private decimal _vlrCP;

        public decimal vlrReceitaTotal
        {
            get { return _vlrReceitaTotal; }
            set { _vlrReceitaTotal = value; }
        }
        private decimal _vlrReceitaTotal;

        public string tpReceita
        {
            get { return _tpReceita; }
            set { _tpReceita = value; }
        }
        private string _tpReceita;

        public string qtdeNaoPagantes
        {
            get { return _qtdeNaoPagantes; }
            set { _qtdeNaoPagantes = value; }
        }
        private string _qtdeNaoPagantes;

        public string qtdePagantes
        {
            get { return _qtdePagantes; }
            set { _qtdePagantes = value; }
        }
        private string _qtdePagantes;

        public string uf
        {
            get { return _uf; }
            set { _uf = value; }
        }
        private string _uf;


        public string codMunic
        {
            get { return _codMunic; }
            set { _codMunic = value; }
        }
        private string _codMunic;



        public string pracaDesportiva
        {
            get { return _pracaDesportiva; }
            set { _pracaDesportiva = value; }
        }
        private string _pracaDesportiva;


        public string nomeVisitante
        {
            get { return _nomeVisitante; }
            set { _nomeVisitante = value; }
        }
        private string _nomeVisitante;


        public string cnpjVisitante
        {
            get { return _cnpjVisitante; }
            set { _cnpjVisitante = value; }
        }
        private string _cnpjVisitante;


        public string cnpjMandante
        {
            get { return _cnpjMandante; }
            set { _cnpjMandante = value; }
        }
        private string _cnpjMandante;


        public string nomeCompeticao
        {
            get { return _nomeCompeticao; }
            set { _nomeCompeticao = value; }
        }
        private string _nomeCompeticao;


        public string modDesportiva
        {
            get { return _modDesportiva; }
            set { _modDesportiva = value; }
        }
        private string _modDesportiva;


        public string categEvento
        {
            get { return _categEvento; }
            set { _categEvento = value; }
        }
        private string _categEvento;


        public string tpCompeticao
        {
            get { return _tpCompeticao; }
            set { _tpCompeticao = value; }
        }
        private string _tpCompeticao;

        public string nrBoletim
        {
            get { return _nrBoletim; }
            set { _nrBoletim = value; }
        }
        private string _nrBoletim;

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
            get { return _cnrInscEstab; }
            set { _cnrInscEstab = value; }
        }
        private string _cnrInscEstab;

        public string tpIngresso
        {
            get { return _tpIngresso; }
            set { _tpIngresso = value; }
        }
        private string _tpIngresso;

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



        public string descIngr
        {
            get { return _descIngr; }
            set { _descIngr = value; }
        }
        private string _descIngr;


        public string qtdeIngrVenda
        {
            get { return _qtdeIngrVenda; }
            set { _qtdeIngrVenda = value; }
        }
        private string _qtdeIngrVenda;

        public string qtdeIngrVendidos
        {
            get { return _qtdeIngrVendidos; }
            set { _qtdeIngrVendidos = value; }
        }
        private string _qtdeIngrVendidos;


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

        public string qtdeIngrDev
        {
            get { return _qtdeIngrDev; }
            set { _qtdeIngrDev = value; }
        }
        private string _qtdeIngrDev;

        public decimal precoIndiv
        {
            get { return _precoIndiv; }
            set { _precoIndiv = value; }
        }
        private decimal _precoIndiv;


        public decimal vlrTotal
        {
            get { return _vlrTotal; }
            set { _vlrTotal = value; }
        }
        private decimal _vlrTotal;

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

        protected override XmlNode ideEstab()
        {
            XmlElement e = XmlDoc.CreateElement("ideEstab");
            e.AppendChild(CreateElement("tpInscEstab", this.tpInscEstab));
            e.AppendChild(CreateElement("cpfResp", this._cnrInscEstab));

            e.AppendChild(boletim());
            e.AppendChild(receitaTotal());

            return e;
        }

        private XmlNode boletim()
        {
            XmlElement e = XmlDoc.CreateElement("boletim");

            e.AppendChild(CreateElement("nrBoletim", this.nrBoletim));
            e.AppendChild(CreateElement("tpCompeticao", this.tpCompeticao));
            e.AppendChild(CreateElement("categEvento", this.categEvento));
            e.AppendChild(CreateElement("modDesportiva", this.modDesportiva));
            e.AppendChild(CreateElement("nomeCompeticao", this.nomeCompeticao));
            e.AppendChild(CreateElement("cnpjMandante", this.cnpjMandante));
            e.AppendChild(CreateElement("cnpjVisitante", this.cnpjVisitante));
            e.AppendChild(CreateElement("nomeVisitante", this.nomeVisitante));
            e.AppendChild(CreateElement("pracaDesportiva", this.pracaDesportiva));
            e.AppendChild(CreateElement("codMunic", this.codMunic));
            e.AppendChild(CreateElement("uf", this.uf));
            e.AppendChild(CreateElement("qtdePagantes", this.qtdePagantes));
            e.AppendChild(CreateElement("qtdeNaoPagantes", this.qtdeNaoPagantes));
            e.AppendChild(receitaIngressos());
            e.AppendChild(outrasReceitas());

            return e;
        }

        private XmlNode receitaIngressos()
        {
            XmlElement e = XmlDoc.CreateElement("receitaIngressos");

            e.AppendChild(CreateElement("tpIngresso", this.tpIngresso));
            e.AppendChild(CreateElement("descIngr", this.descIngr));
            e.AppendChild(CreateElement("qtdeIngrVenda", this.qtdeIngrVenda));
            e.AppendChild(CreateElement("qtdeIngrVendidos", this.qtdeIngrVendidos));
            e.AppendChild(CreateElement("qtdeIngrDev", this.qtdeIngrDev));
            e.AppendChild(CreateElement("precoIndiv", FormatadorReinf.FormatarMoeda(this.precoIndiv)));
            e.AppendChild(CreateElement("vlrTotal", FormatadorReinf.FormatarMoeda(this.vlrTotal)));

            return e;
        }

        private XmlNode outrasReceitas()
        {
            XmlElement e = XmlDoc.CreateElement("outrasReceitas");

            e.AppendChild(CreateElement("tpReceita", this.tpReceita));
            e.AppendChild(CreateElement("vlrReceita", FormatadorReinf.FormatarMoeda(this.vlrReceita)));
            e.AppendChild(CreateElement("descReceita", this.descReceita));
            return e;
        }


        private XmlNode receitaTotal()
        {
            XmlElement e = XmlDoc.CreateElement("receitaTotal");

            e.AppendChild(CreateElement("vlrReceitaTotal", FormatadorReinf.FormatarMoeda(this.vlrReceitaTotal)));
            e.AppendChild(CreateElement("vlrCP", FormatadorReinf.FormatarMoeda(this.vlrCP)));
            e.AppendChild(CreateElement("vlrCPSuspTotal", FormatadorReinf.FormatarMoeda(this.vlrCPSuspTotal)));
            e.AppendChild(CreateElement("vlrCPSuspTotal", FormatadorReinf.FormatarMoeda(this.vlrReceitaClubes)));
            e.AppendChild(CreateElement("vlrCPSuspTotal", FormatadorReinf.FormatarMoeda(this.vlrRetParc)));
            e.AppendChild(infoProc());

            return e;
        }

        private XmlNode infoProc()
        {
            XmlElement e = XmlDoc.CreateElement("infoProc");

            e.AppendChild(CreateElement("tpProc", this.tpProc));
            e.AppendChild(CreateElement("nrProc", this.nrProc));


            //e.AppendChild(CreateElement("codSusp", this.codSusp));
            e.AppendChild(CreateElement("vlrCPSusp", FormatadorReinf.FormatarMoeda(this.vlrCPSusp)));
            return e;
        }

    }
}
