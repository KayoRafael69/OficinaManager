using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;

namespace Oficina.Infra.Data.EntitiesConfiguration
{
    public class PecaEstoqueConfiguration
    {
        public void Configure(EntityTypeBuilder<PecaEstoque> builder)
        {
            builder.ToTable("PecasEstoque");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasIndex(p => p.Codigo)
                .IsUnique();

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.ValorUnitario)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(p => p.QuantidadeEstoque)
                .IsRequired();

            builder.HasMany(p => p.PecasOrdemServicos)
                .WithOne(pos => pos.Peca)
                .HasForeignKey(pos => pos.PecaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
