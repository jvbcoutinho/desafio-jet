using BlueModas.Domain.Cesta;
using BlueModas.Domain.Pedido;
using BlueModas.Domain.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BlueModas.Repository.Context
{
    public class ModaContext : DbContext
    {
        public ModaContext(DbContextOptions<ModaContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory logger = LoggerFactory.Create(c => c.AddConsole());
            optionsBuilder.UseLoggerFactory(logger);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Cesta> Cesta { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ModaContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}