using WebEstoque.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace WebEstoque.Infrastructure.Mappings
{
    public class ItemPedidoMapping : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {

            builder
                .HasKey(ip => new { ip.IdPedido, ip.IdProduto });

            builder.Ignore(p => p.ValorItem);
        }
    }
}
