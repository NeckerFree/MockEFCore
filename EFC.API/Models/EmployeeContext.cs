using Microsoft.EntityFrameworkCore;

namespace EFC.API.Models
{
    public class EmployeeContext: DbContext
    {

        public EmployeeContext(DbContextOptions options)
           : base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
