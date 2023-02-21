using FirmaSiparişYonetim.Application.Repositories.Orders;
using FirmaSiparişYonetim.Domain.Entities;
using FirmaSiparişYonetim.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Persistence.Repositories.Orders
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(FirmaSiparisYonetimDbContext context) : base(context)
        {
        }
    }
}
