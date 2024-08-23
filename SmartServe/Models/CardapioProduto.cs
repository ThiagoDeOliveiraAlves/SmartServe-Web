using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartServe.Models
{
    public class CardapioProduto
    {
        public int CardapioId { get; set; }
        public Cardapio Cardapio { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        

    }
}
