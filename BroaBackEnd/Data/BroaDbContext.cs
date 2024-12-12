using Microsoft.EntityFrameworkCore;
using BroaBackEnd.Models;

namespace BroaBackEnd.Data
{
    public class BroaDbContext : DbContext
    {
        public BroaDbContext(DbContextOptions<BroaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
