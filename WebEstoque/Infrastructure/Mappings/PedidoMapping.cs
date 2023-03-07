using WebEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using WebEstoque.Models;

namespace WebEstoque.Infrastructure.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {

            builder.HasKey(c => c.IdPedido);

            builder.Property(p => p.DataPedido)
               .HasColumnType("DateTime");


            builder.Property(p => p.DataEntrega)
               .HasColumnType("DateTime");
               

            builder
                .OwnsOne(p => p.EnderecoEntrega, e =>
                {
                    e.Ignore(e => e.IdEndereco);
                    e.Ignore(e => e.Selecionado);
                    e.ToTable("Pedido");
                });

        }
    }
}
