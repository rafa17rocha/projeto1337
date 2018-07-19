using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EY.Reinf.Object.Model
{
    [Table("R2010")]
    public class R2010Model
    {
        public string IdentificacaoUnica { get; set; }
        public DateTime DataHoraGeracaoEvento { get; set; }
        public string TipoOperacao { get; set; }

        [Key]
        public int Id { get; set; }
        public string indRetif { get; set; }
        public string nrRecibo { get; set; }
        public string perApur { get; set; }
        public string tpAmb { get; set; }
        public string procEmi { get; set; }
        public string verProc { get; set; }
        public string tpInsc { get; set; }
        public string nrInsc { get; set; }
        public string tpInscEstab { get; set; }
        public string nrInscEstab { get; set; }
        public string indObra { get; set; }
        public string cnpjPrestador { get; set; }
        public string vlrTotalBruto { get; set; }
        public string vlrTotalBaseRet { get; set; }
        public string vlrTotalRetPrinc { get; set; }
        public string vlrTotalRetAdic { get; set; }
        public string vlrTotalNRetPrinc { get; set; }
        public string vlrTotalNRetAdic { get; set; }
        public string indCPRB { get; set; }

        [NotMapped]
        public List<InfoProcRetAdModel> infoProcRetAd { get; set; }

        [NotMapped]
        public List<InfoProcRetPrModel> infoProcRetPr { get; set; }

        [NotMapped]
        public List<NfsModel> nfsModel { get; set; }

        [NotMapped]
        public List<InfoTpServModel> infoTpServ { get; set; }
    }
}
