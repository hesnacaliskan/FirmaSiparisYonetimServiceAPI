using FirmaSiparişYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int urunId { get; set; }
        public int firmaId { get; set; }
        
        public ICollection<Product> Products { get; set; }
        public ICollection<Company> Companies{ get; set; }  
        //public Company Company { get; set; }
        //public Product Product { get; set; }    

    }
}
