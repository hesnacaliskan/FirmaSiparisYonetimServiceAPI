using FirmaSiparişYonetim.Domain.Entities;
using FirmaSiparişYonetim.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Queries.Companies.GetAllCompany
{
    public class GetAllCompanyQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OnayDurumu { get; set; }
        public string SiparisBaslangic { get; set; }
        public string SiparisBitis { get; set; }

    }
}
