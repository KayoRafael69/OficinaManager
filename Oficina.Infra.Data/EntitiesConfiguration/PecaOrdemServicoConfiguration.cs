using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;

namespace Oficina.Infra.Data.EntitiesConfiguration
{
    public class PecaOrdemServicoConfiguration : IEntityTypeConfiguration<PecaOrdemServico>
    {
        public void Configure(EntityTypeBuilder<PecaOrdemServico> builder)
        {
            builder.ToTable("PecasOrdemServico");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Quantidade)
                .IsRequired();

            builder.Property(p => p.ValorUnitario)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.HasOne(p => p.OrdemServico)
                .WithMany(os => os.Pecas)
                .HasForeignKey(p => p.OrdemServicoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Ignore(p => p.ValorTotal);
        }
    }
}