using EY.Reinf.Object.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EY.Reinf.Infra.Context
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=DBEYREINFEntities")
        {

        }

        public virtual DbSet<R1000Model> r1000 { get; set; }
        public virtual DbSet<ContatoModel> contato { get; set; }
        public virtual DbSet<SoftHouseModel> softModel { get; set; }
        public virtual DbSet<R1070Model> r1070 { get; set; }
        public virtual DbSet<MunicipioModel> municipio { get; set; }
        public virtual DbSet<InfoSuspModel> infoSuspModel { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
