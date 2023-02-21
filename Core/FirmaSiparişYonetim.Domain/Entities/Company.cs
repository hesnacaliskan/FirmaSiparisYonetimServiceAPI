using FirmaSiparişYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Domain.Entities
{
    public class Company : BaseEntity
    {
        public int orderId { get; set; }
        
        public string OnayDurumu { get; set; }  
        public string SiparisBaslangic { get; set; }
        public string SiparisBitis { get; set; }
        //public Order Order { get; set; }
        
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }  
    }
}
