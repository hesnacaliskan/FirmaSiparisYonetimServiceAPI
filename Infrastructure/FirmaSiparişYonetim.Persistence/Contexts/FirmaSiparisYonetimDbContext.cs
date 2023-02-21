using FirmaSiparişYonetim.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Persistence.Contexts
{
    public class FirmaSiparisYonetimDbContext : DbContext
    {
        public FirmaSiparisYonetimDbContext(DbContextOptions options) : base(options){ }
        public DbSet<Company> Companies { get; set; }   
        public DbSet<Product> Products { get; set; }    
        public DbSet<Order> Orders { get; set; }
    }
}
