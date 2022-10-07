using AspNetMvcCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcCRUD.Data
{
    public class MvcDemoDbContext : DbContext
    {
        public MvcDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
