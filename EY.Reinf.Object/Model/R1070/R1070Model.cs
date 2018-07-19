using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EY.Reinf.Object.Model
{
    [Table("R1070")]
    public class R1070Model
    {
        public string IdentificacaoUnica { get; set; }
        public DateTime DataHoraGeracaoEvento { get; set; }
        public string TipoOperacao { get; set; }

        [Key]
        public int Id { get; set; }
        public string tpAmb { get; set; }
        public string procEmi { get; set; }
        public string verProc { get; set; }
        public string tpInsc { get; set; }
        public string nrInsc { get; set; }
        public string tpProc { get; set; }
        public string nrProc { get; set; }
        public DateTime iniValid { get; set; }
        public DateTime fimValid { get; set; }
        public string indAutoria { get; set; }

        public string ufVara { get; set; }
        public string codMunic { get; set; }
        public string idVara { get; set; }

        [NotMapped]
        public List<InfoSuspModel> infoSusp { get; set; }
    }
}
