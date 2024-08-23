using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartServe.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria")]
        [MinLength(5, ErrorMessage = "O nome deve ter no mínimo 5 caracteres")]
        [MaxLength(20, ErrorMessage = "O nome não deve ultrapassar 20 caracteres")]
        public string NomeCategoria { get; set; }

        public List <Produto> Produtos { get; set; }
    }
}
