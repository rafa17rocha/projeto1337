using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Object.Model
{
    [Table("InfoProcRetAd")]
    public class InfoProcRetAdModel
    {
        [Key]
        public int Id { get; set; }

        public string tpProcRetAdic { get; set; }
        public string nrProcRetAdic { get; set; }
        public string codSuspAdic { get; set; }
        public string valorAdic { get; set; }

        public int IdR2010 { get; set; }
    }
}
