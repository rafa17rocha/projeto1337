using System;
using System.Xml;

namespace EY.Reinf.Object.Model.VALIDAR
{
    public abstract class EventoPeriodicoReinf
        : EventoReinf
    {
        public DateTime MesAnoApuracao
        {
            get { return _mesAnoApuracao; }
            set { _mesAnoApuracao = value; }
        }
        private DateTime _mesAnoApuracao;

        public bool Retificadora
        {
            get { return _retificadora; }
            set { _retificadora = value; }
        }
        private bool _retificadora;

        public string NumeroRecibo
        {
            get { return _numeroRecibo; }
            set { _numeroRecibo = value; }
        }
        private string _numeroRecibo;

        protected override XmlNode ideEvento()
        {
            XmlElement e = XmlDoc.CreateElement("ideEvento");
            e.AppendChild(CreateElement("indRetif", this.Retificadora ? "2" : "1"));
            if(this.Retificadora)
                e.AppendChild(CreateElement("nrRecibo", this.NumeroRecibo));
            e.AppendChild(CreateElement("perApur", FormatadorReinf.FormatarMesAno(this.MesAnoApuracao)));
            e.AppendChild(CreateElement("tpAmb", ((int) this.Ambiente).ToString()));
            e.AppendChild(CreateElement("procEmi", APLICATIVO_DO_CONTRIBUINTE));
            e.AppendChild(CreateElement("verProc", this.VersaoProcesso));
            return e;
        }
    }
}
