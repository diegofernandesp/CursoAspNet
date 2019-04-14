using CursoAspNet.Domain.Items;
using CursoAspNet.Domain.Operations;
using CursoAspNet.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace CursoAspNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Operation> Operations { get; set; }
    }
}
