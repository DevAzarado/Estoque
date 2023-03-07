using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEstoque.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        public DateTime? DataPedido { get; set; }

        public DateTime? DataEntrega { get; set; }

        public double? ValorTotal { get; set; }

        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente? Cliente { get; set; }

        public Endereco? EnderecoEntrega { get; set; }

        public ICollection<ItemPedido>? ItensPedido { get; set; }
    }
}