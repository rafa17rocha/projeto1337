using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EY.Reinf.Object.Model
{
    [Table("Municipios")]
    public class MunicipioModel
    {
        [Key]
        public string codigo { get; set; }

        public string nome { get; set; }

        public int uf { get; set; }
    }
}
