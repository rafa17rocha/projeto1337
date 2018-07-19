using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Object.Model.VALIDAR.Retorno
{
    public class Ocorrencia
    {
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _codigo;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        private string _descricao;

        public string Localizacao
        {
            get { return _localizacao; }
            set { _localizacao = value; }
        }
        private string _localizacao;
    }
}
