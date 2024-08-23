namespace SmartServe.Models
{
    public class Cardapio
    {
        
        public int CardapioId { get; set; }

        public string NomeCardapio { get; set; }

        public ICollection <CardapioProduto> CardapioProdutos { get; set; }


    }
}
