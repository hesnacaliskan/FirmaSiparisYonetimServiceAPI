using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Commands.Companies.CreateCompany
{
    public class CreateCompanyCommandRequest : IRequest<CreateCompanyCommandResponse>
    {
        public string Name { get; set; }
        public string OnayDurumu { get; set; }
        public string SiparisBaslangic { get; set; }
        public string SiparisBitis { get; set; }
    }
}
