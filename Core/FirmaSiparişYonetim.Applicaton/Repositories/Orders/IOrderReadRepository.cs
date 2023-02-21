using FirmaSiparişYonetim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Repositories.Orders
{
    public interface IOrderReadRepository : IReadRepository<Order>
    {
    }
}
