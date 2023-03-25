using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGP.Domain;

namespace SGP.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //Definindo a tabela no banco
            builder.ToTable("Pedidos");
            //Definindo a chave pk
            builder.HasKey(p => p.Id);
            //Irá executar uma função do SQL e adicionar o valor da DATA no momento da inserção
            builder.Property(p =>p.Data).HasDefaultValueSql("GEDATE()").ValueGeneratedOnAdd();
            //Aqui definimos o tipo do valor que será inserido no banco e será nulo ou não, no caso não
            builder.Property(p => p.NomeProduto).HasColumnType("VARCHAR(80)").IsRequired();
            //Neste caso, foi definido o uso de um enumerador e podemos converter o valor para pegar a string
            builder.Property(p => p.formadeEntrega).HasConversion<string>();
            builder.Property(p => p.Pago).HasColumnType("BIT()");
            builder.Property(p => p.Valor).HasColumnType("FLOAT()");

        }
    }
}