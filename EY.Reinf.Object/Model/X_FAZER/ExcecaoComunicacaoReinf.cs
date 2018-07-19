using System;

namespace EY.Reinf.Object.Model
{
    public class ExcecaoComunicacaoReinf : Exception
    {
        public string Requisicao
        {
            get { return _requisicao; }
            set { _requisicao = value; }
        }
        private string _requisicao;

        public ExcecaoComunicacaoReinf() { }
        public ExcecaoComunicacaoReinf(string message) : base(message) { }
        public ExcecaoComunicacaoReinf(string message, Exception inner) : base(message, inner) { }

        public ExcecaoComunicacaoReinf(string message, Exception inner, string requisicao)
            : base(message, inner)
        {
            this.Requisicao = requisicao;
        }
    }
}
