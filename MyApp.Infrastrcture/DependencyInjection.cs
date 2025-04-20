using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interfaces;
using MyApp.Infrastrcture.Data;
using MyApp.Infrastrcture.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastrcture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastrctureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options =>
            {
                options.UseSqlServer("Server=localhost;Database=APICleanArch;Trusted_Connection=True;TrustServerCertificate=True");
            });
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
