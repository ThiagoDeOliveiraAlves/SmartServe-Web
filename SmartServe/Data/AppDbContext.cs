using Microsoft.EntityFrameworkCore;
using SmartServe.Models;

namespace SmartServe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }
        public DbSet<CardapioProduto> CardapioProduto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoProduto> PedidoProduto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardapioProduto>()
                .HasKey(cp => new { cp.CardapioId, cp.ProdutoId });

            modelBuilder.Entity<PedidoProduto>()
                .HasKey(cp => new { cp.PedidoId, cp.ProdutoId });

            base.OnModelCreating(modelBuilder);
        }
    }

    
}
