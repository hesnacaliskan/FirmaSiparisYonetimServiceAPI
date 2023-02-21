using FirmaSiparişYonetim.Application.Repositories.Products;
using FirmaSiparişYonetim.Domain.Entities;
using FirmaSiparişYonetim.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Persistence.Repositories.Products
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(FirmaSiparisYonetimDbContext context) : base(context)
        {
        }
    }
}
