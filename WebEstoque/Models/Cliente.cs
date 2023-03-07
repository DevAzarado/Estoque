using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEstoque.Models
{
    [Table("Cliente")]
    public class Cliente : Usuario
    {
        [Required, Column(TypeName = "char(14)")]
        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        [NotMapped]
        public int Idade
        {
            get => (int)Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.2425);            
        }

        public ICollection<Endereco>? Enderecos { get; set; }

        public ICollection<Pedido>? Pedidos { get; set; }
    }
}