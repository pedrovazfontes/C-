using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGP.Domain;

namespace SGP.Data.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(p =>p.Id);
            builder.Property(p =>p.Data).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p =>p.Nome).HasColumnType("VARCHAR(40)");
            builder.Property(p =>p.Descricao).HasColumnType("VARCHAR(80)");
            builder.Property(p =>p.Quantidade).HasColumnType("INTEGER");
            builder.Property(p =>p.ValorCompra).HasColumnType("FLOAT");
            builder.Property(p =>p.ValorVenda).HasDefaultValue(0);
            builder.Property(p=>p.Lucro).HasDefaultValue(0);
        }
    }
}