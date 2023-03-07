using System.ComponentModel.DataAnnotations.Schema;
using WebEstoque.Models;

namespace WebEstoque.Models
{
    [Table("ItemPedido")]
    public class ItemPedido
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPedido { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        [ForeignKey("IdPedido")]
        public Pedido? Pedido { get; set; }

        [ForeignKey("IdProduto")]
        public Produto? Produto { get; set; }

        [NotMapped]
        public double ValorItem { get => this.Quantidade * this.ValorUnitario; }
    }
}