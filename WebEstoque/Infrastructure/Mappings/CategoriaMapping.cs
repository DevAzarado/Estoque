using WebEstoque.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace WebEstoque.Infrastructure.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {

            builder.HasKey(e => e.IdCategoria);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(30)");

        }   
    }
}
