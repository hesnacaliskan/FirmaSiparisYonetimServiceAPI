using FirmaSiparişYonetim.Application.Repositories.Companies;
using FirmaSiparişYonetim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Commands.Companies.UpdateCompany
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommandRequest, UpdateCompanyCommandResponse>
    {
        readonly ICompanyReadRepository _companyReadRepository;
        readonly ICompanyWriteRepository _companyWriteRepository;

        public UpdateCompanyCommandHandler(ICompanyReadRepository companyReadRepository, ICompanyWriteRepository companyWriteRepository)
        {
            _companyReadRepository = companyReadRepository;
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            Company company = await _companyReadRepository.GetByIdAsync(request.Id);
            company.OnayDurumu = request.OnayDurumu;
            company.SiparisBaslangic = request.SiparisBaslangic;
            company.SiparisBitis = request.SiparisBitis;
            await _companyWriteRepository.SaveAsync(); 
            return new();
        }
       
    }
}
