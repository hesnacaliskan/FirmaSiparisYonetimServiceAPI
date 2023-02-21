using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Commands.Companies.UpdateCompany
{
    public class UpdateCompanyCommandRequest : IRequest<UpdateCompanyCommandResponse>
    {
        public int Id { get; set; }
        public string OnayDurumu { get; set; }
        public string SiparisBaslangic { get; set; }
        public string SiparisBitis { get; set; }

    }
}
