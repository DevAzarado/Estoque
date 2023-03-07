using WebEstoque.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace WebEstoque.Infrastructure.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(e => e.IdProduto);

            builder.HasIndex(e => e.IdCategoria, "IX_Produto_IdCategoria");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.Preco).HasColumnType("decimal(18, 2)");

           
        }
    }
}
