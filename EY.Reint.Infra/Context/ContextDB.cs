using EY.Reinf.Object.Reinf;
using System.Data.Entity;

namespace EY.Reinf.Infra.Context
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=DBEYREINFEntities")
        {

        }

        public virtual DbSet<alteracao> alteracao { get; set; }
        public virtual DbSet<boletim> boletim { get; set; }
        public virtual DbSet<contato> contato { get; set; }
        public virtual DbSet<dadosProcJud> dadosProcJud { get; set; }
        public virtual DbSet<evtAssocDespRec> evtAssocDespRec { get; set; }
        public virtual DbSet<evtAssocDespRep> evtAssocDespRep { get; set; }
        public virtual DbSet<evtComProd> evtComProd { get; set; }
        public virtual DbSet<evtCPRB> evtCPRB { get; set; }
        public virtual DbSet<evtEspDesportivo> evtEspDesportivo { get; set; }
        public virtual DbSet<evtExclusao> evtExclusao { get; set; }
        public virtual DbSet<evtFechaEvPer> evtFechaEvPer { get; set; }
        public virtual DbSet<evtInfoContri> evtInfoContri { get; set; }
        public virtual DbSet<evtReabreEvPer> evtReabreEvPer { get; set; }
        public virtual DbSet<evtServPrest> evtServPrest { get; set; }
        public virtual DbSet<evtServTom> evtServTom { get; set; }
        public virtual DbSet<evtTabProcesso> evtTabProcesso { get; set; }
        public virtual DbSet<exclusao> exclusao { get; set; }
        public virtual DbSet<ideContri> ideContri { get; set; }
        public virtual DbSet<ideEstab> ideEstab { get; set; }
        public virtual DbSet<ideEstabObra> ideEstabObra { get; set; }
        public virtual DbSet<ideEstabPrest> ideEstabPrest { get; set; }
        public virtual DbSet<ideEvento> ideEvento { get; set; }
        public virtual DbSet<idePeriodo> idePeriodo { get; set; }
        public virtual DbSet<idePrestServ> idePrestServ { get; set; }
        public virtual DbSet<ideProcesso> ideProcesso { get; set; }
        public virtual DbSet<ideRespInf> ideRespInf { get; set; }
        public virtual DbSet<ideTomador> ideTomador { get; set; }
        public virtual DbSet<inclusao> inclusao { get; set; }
        public virtual DbSet<infoCadastro> infoCadastro { get; set; }
        public virtual DbSet<infoComProd> infoComProd { get; set; }
        public virtual DbSet<infoContri> infoContri { get; set; }
        public virtual DbSet<infoCPRB> infoCPRB { get; set; }
        public virtual DbSet<infoEFR> infoEFR { get; set; }
        public virtual DbSet<infoExclusao> infoExclusao { get; set; }
        public virtual DbSet<infoFech> infoFech { get; set; }
        public virtual DbSet<infoProc> infoProc { get; set; }
        public virtual DbSet<infoProcesso> infoProcesso { get; set; }
        public virtual DbSet<infoProcRetAd> infoProcRetAd { get; set; }
        public virtual DbSet<infoProcRetPr> infoProcRetPr { get; set; }
        public virtual DbSet<infoRecurso> infoRecurso { get; set; }
        public virtual DbSet<infoServPrest> infoServPrest { get; set; }
        public virtual DbSet<infoServTom> infoServTom { get; set; }
        public virtual DbSet<infoSusp> infoSusp { get; set; }
        public virtual DbSet<infoTpServ> infoTpServ { get; set; }
        public virtual DbSet<nfs> nfs { get; set; }
        public virtual DbSet<novaValidade> novaValidade { get; set; }
        public virtual DbSet<outrasReceitas> outrasReceitas { get; set; }
        public virtual DbSet<receitaIngressos> receitaIngressos { get; set; }
        public virtual DbSet<receitaTotal> receitaTotal { get; set; }
        public virtual DbSet<recursosRec> recursosRec { get; set; }
        public virtual DbSet<recursosRep> recursosRep { get; set; }
        public virtual DbSet<softHouse> softHouse { get; set; }
        public virtual DbSet<tipoAjuste> tipoAjuste { get; set; }
        public virtual DbSet<tipoCod> tipoCod { get; set; }
        public virtual DbSet<tipoCom> tipoCom { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
