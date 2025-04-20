using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;

namespace MyApp.Infrastrcture.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) :DbContext(options)
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
