using BlueModas.Domain.Cesta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueModas.Repository.Mappings
{
    public class CestaMapping : IEntityTypeConfiguration<Cesta>
    {
        public void Configure(EntityTypeBuilder<Cesta> builder)
        {
            builder.ToTable("Cestas");
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Itens).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}