using FirmaSiparişYonetim.Application.Repositories.Companies;
using FirmaSiparişYonetim.Application.Repositories.Orders;
using FirmaSiparişYonetim.Application.Repositories.Products;
using FirmaSiparişYonetim.Persistence.Contexts;
using FirmaSiparişYonetim.Persistence.Repositories.Companies;
using FirmaSiparişYonetim.Persistence.Repositories.Orders;
using FirmaSiparişYonetim.Persistence.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddDbContext<FirmaSiparisYonetimDbContext>(options => options.UseSqlServer("Server=LAPTOP-PBH375GS\\SQLEXPRESS;Database=FirmaSiparisYonetimDb;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddDbContext<FirmaSiparisYonetimDbContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Scoped);
            services.AddScoped<ICompanyReadRepository,CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository,CompanyWriteRepository>();
            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}
