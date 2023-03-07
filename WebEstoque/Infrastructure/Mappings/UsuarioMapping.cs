using WebEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace WebEstoque.Infrastructure.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.IdUsuario);

            builder.Property(c => c.Nome)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(c => c.Email)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(c => c.Senha)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(u => u.DataCadastro)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            
        }
    }
}
