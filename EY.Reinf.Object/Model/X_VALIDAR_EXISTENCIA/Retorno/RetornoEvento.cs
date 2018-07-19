using System;
using System.Collections.Generic;

namespace EY.Reinf.Object.Model.VALIDAR.Retorno
{
    public class RetornoEvento
    {
        public StatusRetorno Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private StatusRetorno _status;

        public string IdRetornoEvento
        {
            get { return _idRetornoEvento; }
            set { _idRetornoEvento = value; }
        }
        private string _idRetornoEvento;

        public string NumeroInscricaoContribuinte
        {
            get { return _numeroInscricaoContribuinte; }
            set { _numeroInscricaoContribuinte = value; }
        }
        private string _numeroInscricaoContribuinte;

        public DateTime DataHoraProcessamento
        {
            get
            {
                DateTime dh;
                if(DateTime.TryParseExact(this.RawDataHoraProcessamento,
                    "yyyy-MM-ddTHH:mm:ss.fffffffzzz",
                    System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat,
                    System.Globalization.DateTimeStyles.None,
                    out dh))
                {
                    return dh;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }

        public string RawDataHoraProcessamento
        {
            get { return _rawDataHoraProcessamento; }
            set { _rawDataHoraProcessamento = value; }
        }
        private string _rawDataHoraProcessamento;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private string _tipo;

        public string IdEventoTransmitido
        {
            get { return _idEventoTransmitido; }
            set { _idEventoTransmitido = value; }
        }
        private string _idEventoTransmitido;

        public string NumeroRecibo
        {
            get { return _numeroRecibo; }
            set { _numeroRecibo = value; }
        }
        private string _numeroRecibo;

        public bool SucessoEvento
        {
            get
            {
                return this.Status.Codigo == "0";
            }
        }

        public List<Ocorrencia> Ocorrencias
        {
            get { return _ocorrencias; }
        }
        private List<Ocorrencia> _ocorrencias = new List<Ocorrencia>();
    }
}
