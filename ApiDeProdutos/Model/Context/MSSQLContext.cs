using Microsoft.EntityFrameworkCore;

namespace ApiDeProdutos.Model.Context
{
    public class MSSQLContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public MSSQLContext(DbContextOptions<MSSQLContext> options) : base(options)
        { 
        
        }
    }
}
