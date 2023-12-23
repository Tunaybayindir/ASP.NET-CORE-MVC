using Microsoft.EntityFrameworkCore;

namespace Departmanlar.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }
    }
}
