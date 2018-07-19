using System;
using System.Xml;

namespace EY.Reinf.Object.Model
{
    public class R1000 : EventoReinf
    {
        protected override string NomeSchemaEvento
        {
            get { return "evtInfoContribuinte"; }
        }

        protected override string NomeTagEvento
        {
            get { return "evtInfoContri"; }
        }

        public DateTime MesAnoInicioValidade
        {
            get { return _mesAnoInicioValidade; }
            set { _mesAnoInicioValidade = value; }
        }
        private DateTime _mesAnoInicioValidade;

        public DateTime MesAnoFimValidade
        {
            get { return _mesAnoFimValidade; }
            set { _mesAnoFimValidade = value; }
        }
        private DateTime _mesAnoFimValidade;

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

        public string ClassificacaoTributaria
        {
            get { return _classificacaoTributaria; }
            set { _classificacaoTributaria = value; }
        }
        private string _classificacaoTributaria;

        public bool EntregaECD
        {
            get { return _entregaECD; }
            set { _entregaECD = value; }
        }
        private bool _entregaECD;

        public bool Desoneracao
        {
            get { return _desoneracao; }
            set { _desoneracao = value; }
        }
        private bool _desoneracao;

        public Enumeracoes.IndicativosSituacoesPJ SituacaoPJ
        {
            get { return _situacaoPJ; }
            set { _situacaoPJ = value; }
        }
        private Enumeracoes.IndicativosSituacoesPJ _situacaoPJ;

        public ContatoModel Contato
        {
            get { return _contato; }
            set { _contato = value; }
        }
        private ContatoModel _contato;

        public SoftHouseModel SoftwareHouse
        {
            get { return _softwareHouse; }
            set { _softwareHouse = value; }
        }
        private SoftHouseModel _softwareHouse;

        protected override XmlNode info()
        {
            XmlElement e = XmlDoc.CreateElement("infoContri");
            e.AppendChild(operacao());
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
            //        //}
            //}
        }

        private XmlNode operacao()
        {
            XmlElement e = XmlDoc.CreateElement(this.Operacao.ToString().ToLower());
            e.AppendChild(idePeriodo());
            if (this.Operacao != Enumeracoes.OperacoesReinf.EXCLUSAO)
            {
                e.AppendChild(infoCadastro());
                if (this.Operacao == Enumeracoes.OperacoesReinf.ALTERACAO)
                    e.AppendChild(novaValidade());
            }
            return e;
        }

        private XmlNode idePeriodo()
        {
            XmlElement e = XmlDoc.CreateElement("idePeriodo");
            e.AppendChild(CreateElement("iniValid", FormatadorReinf.FormatarMesAno(this.MesAnoInicioValidade)));
            if (this.MesAnoFimValidade > DateTime.MinValue)
                e.AppendChild(CreateElement("fimValid", FormatadorReinf.FormatarMesAno(this.MesAnoFimValidade)));
            return e;
        }

        private XmlNode infoCadastro()
        {
            XmlElement e = XmlDoc.CreateElement("infoCadastro");
            e.AppendChild(CreateElement("classTrib", this.ClassificacaoTributaria));
            e.AppendChild(CreateElement("indEscrituracao", this.EntregaECD ? "1" : "0"));
            e.AppendChild(CreateElement("indDesoneracao", this.Desoneracao ? "1" : "0"));
            e.AppendChild(CreateElement("indAcordoIsenMulta", "0"));
            //e.AppendChild(CreateElement("indSitPJ", ((int)this.SituacaoPJ).ToString()));
            e.AppendChild(contato());

            if (this.SoftwareHouse != null)
                e.AppendChild(softHouse());
            return e;
        }

        private XmlNode contato()
        {
            if (this.Contato == null)
                throw new InvalidOperationException("sem contato");

            XmlElement e = XmlDoc.CreateElement("contato");
            e.AppendChild(CreateElement("nmCtt", this.Contato.nmCtt));
            e.AppendChild(CreateElement("cpfCtt", FormatadorReinf.FormatarCPFCNPJCNO(this.Contato.cpfCtt)));
            if (!string.IsNullOrEmpty(this.Contato.foneFixo))
                e.AppendChild(CreateElement("foneFixo", FormatadorReinf.FormatarTelefone(this.Contato.foneFixo)));
            if (!string.IsNullOrEmpty(this.Contato.foneCel))
                e.AppendChild(CreateElement("foneCel", FormatadorReinf.FormatarTelefone(this.Contato.foneCel)));
            if (!string.IsNullOrEmpty(this.Contato.email))
                e.AppendChild(CreateElement("email", this.Contato.email));
            return e;
        }

        private XmlNode softHouse()
        {
            XmlElement e = XmlDoc.CreateElement("softHouse");
            e.AppendChild(CreateElement("cnpjSoftHouse", FormatadorReinf.FormatarCPFCNPJCNO(this.SoftwareHouse.cnpjSoftHouse)));
            e.AppendChild(CreateElement("nmRazao", this.SoftwareHouse.nmRazao));
            e.AppendChild(CreateElement("nmCont", this.SoftwareHouse.nmCont));
            if (!string.IsNullOrEmpty(this.SoftwareHouse.telefone))
                e.AppendChild(CreateElement("telefone", FormatadorReinf.FormatarTelefone(this.SoftwareHouse.telefone)));
            if (!string.IsNullOrEmpty(this.SoftwareHouse.email))
                e.AppendChild(CreateElement("email", this.SoftwareHouse.email));
            return e;
        }

        private XmlNode novaValidade()
        {
            XmlElement e = XmlDoc.CreateElement("novaValidade");
            e.AppendChild(CreateElement("iniValid", FormatadorReinf.FormatarMesAno(this.NovoMesAnoInicioValidade)));
            if (this.NovoMesAnoFimValidade > DateTime.MinValue)
                e.AppendChild(CreateElement("fimValid", FormatadorReinf.FormatarMesAno(this.NovoMesAnoFimValidade)));
            return e;
        }
    }
}
