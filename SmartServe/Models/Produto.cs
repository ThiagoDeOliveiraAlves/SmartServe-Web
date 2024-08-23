using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartServe.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto deve ser informado")]
        [Display(Name = "Nome do produto")]
        [MinLength(3, ErrorMessage = "O nome do produto deve ter pelo menos 3 caracteres")] 
        [MaxLength(20, ErrorMessage = "O nome do produto deve ter no máximo 20 caracteres")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Escreve uma descrição sobre o produto")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no mínimo 10 caracteres")]
        [MaxLength(100, ErrorMessage = "A descrição não deve ultrapassar 100 caracteres")]
        public string Descricao { get; set; }

        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe a categoria do produto")]
        [Display(Name = "Categoria")]
        public virtual Categoria Categoria { get; set; }

        public ICollection <CardapioProduto> CardapioProduto { get; set; }

        [Required(ErrorMessage = "O preço do produto deve ser informado")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.10, 9999.99, ErrorMessage = "O valor deve estar entre 0,10  e 9999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "URL da imagem")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "URL da imagem thumbnail")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        
    }
}
