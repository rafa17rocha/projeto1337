using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Object.Model
{
    [Table("InfoProcRetPr")]
    public class InfoProcRetPrModel
    {
        [Key]
        public int Id { get; set; }

        public string tpProcRetPrinc { get; set; }
        public string nrProcRetPrinc { get; set; }
        public string codSuspPrinc { get; set; }
        public string valorPrinc { get; set; }

        public int IdR2010 { get; set; }
    }
}
