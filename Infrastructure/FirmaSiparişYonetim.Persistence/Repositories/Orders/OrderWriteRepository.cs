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
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(FirmaSiparisYonetimDbContext context) : base(context)
        {
        }
    }
}
