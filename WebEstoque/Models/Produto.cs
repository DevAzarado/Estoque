using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEstoque.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        [Required, MaxLength(20)]
        public string? Nome { get; set; }
        public int Estoque { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categoria? Categoria { get; set; }

    }
}
