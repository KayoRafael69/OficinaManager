using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;

namespace Oficina.Infra.Data.EntitiesConfiguration
{
    public class MecanicoConfiguration
    {
        public void Configure(EntityTypeBuilder<Mecanico> builder)
        {
            builder.ToTable("Mecanicos");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(m => m.Especialidade)
                .IsRequired();

            builder.HasMany(m => m.OrdensServico)
                .WithOne(os => os.Mecanico)
                .HasForeignKey(os => os.MecanicoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
