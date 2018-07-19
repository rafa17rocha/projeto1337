using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EY.Reinf.Object.Model
{
    [Table("Contato")]
    public class ContatoModel
    {
        [Key]
        public int Id { get; set; }

        public string nmCtt { get; set; }

        public string cpfCtt { get; set; }

        public string foneFixo { get; set; }

        public string foneCel { get; set; }

        public string email { get; set; }

        public int IdR1000 { get; set; }
    }
}
