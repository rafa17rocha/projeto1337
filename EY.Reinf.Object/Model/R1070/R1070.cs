using System;
using System.Xml;

namespace EY.Reinf.Object.Model
{
    public class R1070 : EventoReinf1070
    {
        protected override string NomeSchemaEvento
        {
            //get { return "evtInfoContribuinte"; }
            get { return "evtTabProcesso"; }

        }

        protected override string NomeTagEvento
        {
            get { return "evtTabProcesso"; }
        }

        public string CodigoIndicativoSuspensao
        {//codSusp
            get { return _codigoIndicativoSuspensao; }
            set { _codigoIndicativoSuspensao = value; }
        }

        private string _codigoIndicativoSuspensao;


        public string IndicativoDeSuspencao
        {//indSusp
            get { return _indicativoDeSuspencao; }
            set { _indicativoDeSuspencao = value; }
        }
        private string _indicativoDeSuspencao;


        public DateTime DataDecisao
        {//dtDecisao
            get { return _dtDecisao; }
            set { _dtDecisao = value; }
        }
        private DateTime _dtDecisao;


        public string IndicativodeDeposito
        {
            get { return _indDeposito; }
            set { _indDeposito = value; }
        }
        private string _indDeposito;


        public string TipoDeProcesso
        {
            get { return _tipoDeProcesso; }
            set { _tipoDeProcesso = value; }
        }
        private string _tipoDeProcesso;


        public string NumeroProcesso
        {
            get { return _numeroprocesso; }
            set { _numeroprocesso = value; }
        }
        private string _numeroprocesso;


        public string IndicativoAuditoria
        {
            get { return _indicativoAuditoria; }
            set { _indicativoAuditoria = value; }
        }
        private string _indicativoAuditoria;


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

        public Contato Contato
        {
            get { return _contato; }
            set { _contato = value; }
        }
        private Contato _contato;

        public Contato SoftwareHouse
        {
            get { return _softwareHouse; }
            set { _softwareHouse = value; }
        }
        private Contato _softwareHouse;



        public string IdentificacaoUnidade
        {//ufVara
            get { return _identificacaoUnidade; }
            set { _identificacaoUnidade = value; }
        }
        private string _identificacaoUnidade;


        public string CodigoMunicipio
        {//codMunic
            get { return _codigoMunicipio; }
            set { _codigoMunicipio = value; }
        }
        private string _codigoMunicipio;


        public string CodigoIdentificacaoVara
        {//idVara
            get { return _codigoIdentificacaoVara; }
            set { _codigoIdentificacaoVara = value; }
        }
        private string _codigoIdentificacaoVara;


        protected override XmlNode info()
        {
            XmlElement e = XmlDoc.CreateElement("infoProcesso");
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
            //}
        }

        private XmlNode operacao()
        {
            XmlElement e = XmlDoc.CreateElement(this.Operacao.ToString().ToLower());
            e.AppendChild(ideProcesso());

            if(this.Operacao != Enumeracoes.OperacoesReinf.EXCLUSAO)
            {
                //e.AppendChild(infoSusp());
                if(this.Operacao == Enumeracoes.OperacoesReinf.ALTERACAO)
                    e.AppendChild(novaValidade());
            }

            return e;
        }

        private XmlNode ideProcesso()
        {
            XmlElement e = XmlDoc.CreateElement("ideProcesso");
            e.AppendChild(CreateElement("tpProc", this.TipoDeProcesso));
            e.AppendChild(CreateElement("nrProc", this.NumeroProcesso));
            e.AppendChild(CreateElement("iniValid", FormatadorReinf.FormatarMesAno(this.MesAnoInicioValidade)));
            if(this.MesAnoFimValidade > DateTime.MinValue)
                e.AppendChild(CreateElement("fimValid", FormatadorReinf.FormatarMesAno(this.MesAnoFimValidade)));
            e.AppendChild(CreateElement("indAutoria", this.IndicativoAuditoria));

            e.AppendChild(infoSusp());

            return e;
        }

        private XmlNode infoSusp()
        {
            XmlElement e = XmlDoc.CreateElement("infoSusp");
            //Verificar qdo adicionar esse nó
            //e.AppendChild(CreateElement("codSusp", this.CodigoIndicativoSuspensao));
            e.AppendChild(CreateElement("indSusp", this.IndicativoDeSuspencao));
            e.AppendChild(CreateElement("dtDecisao", FormatadorReinf.FormatarData(this.DataDecisao)));
            e.AppendChild(CreateElement("indDeposito", this.IndicativodeDeposito));

            //VERIFICAR A NECESSIDADE DE INCLUIR ESSE NÓ!
            //e.AppendChild(dadosProcJud());

            //if (this.SoftwareHouse != null)
            //e.AppendChild(softHouse());

            return e;
        }

        private XmlNode contato()
        {
            if(this.Contato == null)
                throw new InvalidOperationException("sem contato");

            XmlElement e = XmlDoc.CreateElement("contato");
            e.AppendChild(CreateElement("nmCtt", this.Contato.Nome));
            e.AppendChild(CreateElement("cpfCtt", FormatadorReinf.FormatarCPFCNPJCNO(this.Contato.CPF)));
            if(!string.IsNullOrEmpty(this.Contato.TelefoneFixo))
                e.AppendChild(CreateElement("foneFixo", FormatadorReinf.FormatarTelefone(this.Contato.TelefoneFixo)));
            if(!string.IsNullOrEmpty(this.Contato.TelefoneMovel))
                e.AppendChild(CreateElement("foneCel", FormatadorReinf.FormatarTelefone(this.Contato.TelefoneMovel)));
            if(!string.IsNullOrEmpty(this.Contato.Email))
                e.AppendChild(CreateElement("email", this.Contato.Email));
            return e;
        }

        private XmlNode dadosProcJud()
        {
            XmlElement e = XmlDoc.CreateElement("dadosProcJud");
            e.AppendChild(CreateElement("ufVara", this.IdentificacaoUnidade));
            e.AppendChild(CreateElement("codMunic", this.CodigoMunicipio));
            e.AppendChild(CreateElement("idVara", this.CodigoIdentificacaoVara));
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
