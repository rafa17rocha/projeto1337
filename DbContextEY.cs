using System;

public class DbContextEY : DbContext
{
    static DbContextEY()
    {
        Database.SetInitializer<Contexto>(null);
    }

    public Contexto() : base("Name=ContextDb")
    {

    }

    public DbSet<> Cliente { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Configurations.Add(new ClienteConfiguration());
    }
}