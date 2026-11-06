using Microsoft.EntityFrameworkCore;
using SurfWeb.Models;

namespace SurfWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }

        public DbSet<Brand> Brand { get; set; }
    }
}
