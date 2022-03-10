using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Example.Infra.Data
{
    /// <summary>
    /// Referência de artigo para conseguir criar modelos de configuração
    /// https://docs.microsoft.com/pt-br/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core
    /// Rererência de artigo para conseguir criar migration a partir de dominios
    /// https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli
    /// </summary>
    public class ExampleContext : DbContext
    {
        public DbSet<Domain.ExampleAggregate.Example> Example { get; set; }
        public ExampleContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ExampleEntityTypeConfiguration());
            modelBuilder.Entity<Domain.ExampleAggregate.Example>();

        }
    }

    public class ExampleEntityTypeConfiguration : IEntityTypeConfiguration<Domain.ExampleAggregate.Example>
    {
        public void Configure(EntityTypeBuilder<Domain.ExampleAggregate.Example> orderConfiguration)
        {
            orderConfiguration.ToTable("Example", "dbo");

            orderConfiguration.HasKey(o => o.Id);
            orderConfiguration.Property(o => o.Id).UseIdentityColumn();
            orderConfiguration.Property(o => o.Name).IsRequired();
            orderConfiguration.Property(o => o.Age).IsRequired();
        }
    }
}
