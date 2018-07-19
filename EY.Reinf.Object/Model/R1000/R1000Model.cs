using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EY.Reinf.Object.Model
{
    [Table("R1000")]
    public class R1000Model
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
        public DateTime iniValid { get; set; }
        public DateTime fimValid { get; set; }
        public string classTrib { get; set; }
        public string indEscrituracao { get; set; }
        public string indDesoneracao { get; set; }
        public string indAcordoIsenMulta { get; set; }
        public string indSitPJ { get; set; }
        public string ideEFR { get; set; }
        public string cnpjEFR { get; set; }

        [NotMapped]
        public ContatoModel contato { get; set; }

        [NotMapped]
        public List<SoftHouseModel> softwareHouse { get; set; }
    }
}
