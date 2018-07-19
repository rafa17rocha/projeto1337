using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EY.Reinf.Object.Model
{
    [Table("SoftHouse")]
    public class SoftHouseModel
    {
        [Key]
        public int Id { get; set; }

        public string cnpjSoftHouse { get; set; }

        public string nmRazao { get; set; }

        public string nmCont { get; set; }

        public string telefone { get; set; }

        public string email { get; set; }

        public int IdR1000 { get; set; }
    }
}
