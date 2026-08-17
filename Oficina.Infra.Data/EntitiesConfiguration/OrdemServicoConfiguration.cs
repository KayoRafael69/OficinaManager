using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Entities;

namespace Oficina.Infra.Data.EntitiesConfiguration
{
    public class OrdemServicoConfiguration
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdensServico");

            builder.HasKey(os => os.Id);

            builder.Property(os => os.NumeroOrdem)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasIndex(os => os.NumeroOrdem)
                .IsUnique();

            builder.Property(os => os.Status)
                .IsRequired();

            builder.Property(os => os.Descricao)
                .HasMaxLength(500);

            builder.Property(os => os.ValorMaoDeObra)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(os => os.DataAbertura)
                .IsRequired();

            // Ignora as propriedades calculadas (não viram coluna no banco)
            builder.Ignore(os => os.ValorPecas);
            builder.Ignore(os => os.ValorTotal);
        }
    }
}