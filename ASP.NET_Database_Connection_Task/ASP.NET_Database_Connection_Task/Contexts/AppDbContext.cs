using Microsoft.EntityFrameworkCore;
using ASP.NET_Database_Connection_Task.Models;

namespace ASP.NET_Database_Connection_Task.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee>? Employees { get; set; }

    }
}