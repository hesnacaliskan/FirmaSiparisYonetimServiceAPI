using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.DTOs.Orders
{
    public class CreateOrder
    {
        public int urunId { get; set; }
        public int firmaId { get; set; }
        public string Name { get; set; }
    }
}
