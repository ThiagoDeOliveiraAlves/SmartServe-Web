using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartServe.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        public DateTime DataPedido = DateTime.Now;
        public List <Produto> Produtos { get; set; }

        [Display(Name = "Status")]
        public StatusPedido StatusPedido { get; set; }

        public ICollection<PedidoProduto> PedidoProduto { get; set; }

        [Required]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.10, 9999.99, ErrorMessage ="O valor deve estar entre 0,10  e 9999,99")]
        public decimal TotalPedido { get; set; }
    }
}
