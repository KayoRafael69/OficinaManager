using Microsoft.EntityFrameworkCore;
using Oficina.Domain.Entities;

namespace Oficina.Infra.Data.ContextDb
{
    public class OficinaDbContext : DbContext
    {
        public OficinaDbContext(DbContextOptions<OficinaDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<PecaEstoque> PecasEstoque { get; set; }
        public DbSet<OrdemServico> OrdensServico { get; set; }
        public DbSet<PecaOrdemServico> PecasOrdemServico { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OficinaDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            AtualizarDataAtualizacao();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AtualizarDataAtualizacao();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void AtualizarDataAtualizacao()
        {
            var entradas = ChangeTracker.Entries<EntidadeBase>()
                .Where(e => e.State == EntityState.Modified);

            foreach (var entrada in entradas)
                entrada.Entity.DataAtualizacao = DateTime.UtcNow;
        }
    }
}