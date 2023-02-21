using FirmaSiparişYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.DTOs.Companies
{
    public class CompanyViewDtos : BaseEntity
    {
        public string OnayDurumu { get; set; }
        public string SiparisBaslangic { get; set; }
        public string SiparisBitis { get; set; }
    }
}
