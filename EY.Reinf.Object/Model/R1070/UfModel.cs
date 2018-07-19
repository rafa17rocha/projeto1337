using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Object.Model
{
    public class UfModel
    {
        public UfModel(string sigla, int codigo)
        {
            this.sigla = sigla;
            this.codigo = codigo;
        }

        public string sigla { get; set; }

        public int codigo { get; set; }
    }
}
