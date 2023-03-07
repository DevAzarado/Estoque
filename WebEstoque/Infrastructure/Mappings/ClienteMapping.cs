using WebEstoque.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace WebEstoque.Infrastructure.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {

            entity.ToTable("Cliente");

            entity.Property(e => e.CPF)
                .IsRequired()
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("CPF")
                .IsFixedLength(true);

            entity
               .OwnsMany(c => c.Enderecos, e =>
               {
                   e.WithOwner().HasForeignKey("IdUsuario");
                   e.HasKey("IdUsuario", "IdEndereco");
               });

            
        }
    }
}
