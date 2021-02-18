using BlueModas.Domain.Pedido;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModas.Repository.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Itens).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}