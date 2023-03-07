using System.ComponentModel.DataAnnotations;

namespace WebEstoque.Models
{
    public class Categoria
    {

        [Key]
        public int IdCategoria { get; set; }
        [Required, MaxLength(128)]
        public string Nome { get; set; }
    }
}
