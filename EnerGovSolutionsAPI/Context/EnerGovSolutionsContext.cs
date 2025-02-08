using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using EnerGovSolutionsAPI.Models;
namespace EnerGovSolutionsAPI.Context
{
    public class EnerGovSolutionsContext : DbContext
    {
        public EnerGovSolutionsContext(DbContextOptions<EnerGovSolutionsContext> options):base(options)
        {
            
        }
        public DbSet<Employee> employee{ get; set; }
        public DbSet<Roles> roles{ get; set; }
    }
}
