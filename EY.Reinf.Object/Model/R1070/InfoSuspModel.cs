using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Object.Model
{
    [Table("InfoSusp")]
    public class InfoSuspModel
    {
        [Key]
        public int Id { get; set; }

        public string codSusp { get; set; }
        public string indSusp { get; set; }
        public DateTime dtDecisao { get; set; }
        public string indDeposito { get; set; }

        public int IdR1070 { get; set; }
    }
}
