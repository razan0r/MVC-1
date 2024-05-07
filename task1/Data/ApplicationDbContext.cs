using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using task1.Models;

namespace task1.Data
{
    public class ApplicationDbContext :DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =. ; database=task; trusted_connection=true;TrustServerCertificate=true ");
        }
    }
}
