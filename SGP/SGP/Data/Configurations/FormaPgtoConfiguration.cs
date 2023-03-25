using Microsoft.EntityFrameworkCore;
using SGP.Domain;

namespace SGP.Data.Configurations
{
    public class FormaPgtoConfiguration : IEntityTypeConfiguration<FormadePgto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FormadePgto> builder)
        {
            builder.ToTable("FormadePgto");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(30)");
        }
    }
}

