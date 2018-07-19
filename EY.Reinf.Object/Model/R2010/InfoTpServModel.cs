using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY.Reinf.Object.Model
{
    [Table("InfoTpServ")]
    public class InfoTpServModel
    {
        [Key]
        public int Id { get; set; }

        public string tpServico { get; set; }
        public string vlrBaseRet { get; set; }
        public string vlrRetencao { get; set; }
        public string vlrRetSub { get; set; }
        public string vlrNRetPrinc { get; set; }
        public string vlrServicos15 { get; set; }
        public string vlrServicos20 { get; set; }
        public string vlrServicos25 { get; set; }
        public string vlrAdicional { get; set; }
        public string vlrNRetAdic { get; set; }

        public int IdNfs { get; set; }
    }
}
