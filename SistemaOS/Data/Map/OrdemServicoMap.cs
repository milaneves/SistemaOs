

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaOS.Models;

namespace SistemaOS.Data.Map
{
    public class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NumeroOS);
            builder.Property(x => x.TituloServico).IsRequired().HasColumnType("varchar(50)"); ;
            builder.Property(x => x.NomeCliente).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.CNPJCliente).IsRequired().HasColumnType("varchar(20)");
            builder.Property(x => x.CPFPrestador).IsRequired().HasColumnType("varchar(15)");
            builder.Property(x => x.NomePrestador).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.DataExecucao);
            builder.Property(x => x.Valor);

        }
    }
}
