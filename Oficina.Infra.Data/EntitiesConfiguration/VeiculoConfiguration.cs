using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;

namespace Oficina.Infra.Data.EntitiesConfiguration
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Marca)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(v => v.Modelo)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(v => v.Placa)
                .IsRequired()
                .HasMaxLength(8);

            builder.HasIndex(v => v.Placa)
                .IsUnique();

            builder.Property(v => v.Cor)
                .HasMaxLength(30);

            builder.HasMany(v => v.OrdensServico)
                .WithOne(os => os.Veiculo)
                .HasForeignKey(os => os.VeiculoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
