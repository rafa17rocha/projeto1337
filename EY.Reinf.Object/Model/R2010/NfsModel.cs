using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EY.Reinf.Object.Model
{
    [Table("Nfs")]
    public class NfsModel
    {
        [Key]
        public int Id { get; set; }

        public string serie { get; set; }
        public string numDocto { get; set; }
        public string dtEmissaoNF { get; set; }
        public string vlrBruto { get; set; }
        public string obs { get; set; }

        public int IdR2010 { get; set; }
    }
}
