using FirmaSiparişYonetim.Application.DTOs.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Queries.Companies.GetAllCompany
{
    public class GetAllCompanyQueryRequest : IRequest<List<GetAllCompanyQueryResponse>> 
    {        public int Id { get; set; }
        public string Name { get; set; }
        public string OnayDurumu { get; set; }
        public string SiparisBaslangic { get; set; }
        public string SiparisBitis { get; set; }
    }
}
