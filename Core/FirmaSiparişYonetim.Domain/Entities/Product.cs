using FirmaSiparişYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int firmaId { get; set; }
        //public Company company { get; set; }    
        public int Stok { get; set; }
        public long Fiyat { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Company> Companies { get; set; }
        
    }
}
