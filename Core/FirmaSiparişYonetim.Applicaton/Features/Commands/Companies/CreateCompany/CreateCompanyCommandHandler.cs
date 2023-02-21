using FirmaSiparişYonetim.Application.Repositories.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Commands.Companies.CreateCompany
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommandRequest, CreateCompanyCommandResponse>
    {
        readonly ICompanyWriteRepository _companyWriteRepository;

        public CreateCompanyCommandHandler(ICompanyWriteRepository companyWriteRepository)
        {
            _companyWriteRepository = companyWriteRepository;        }

      
        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _companyWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                OnayDurumu = request.OnayDurumu,
                SiparisBaslangic = request.SiparisBaslangic,
                SiparisBitis = request.SiparisBitis,
                CreatedTime = DateTime.UtcNow,
            }); ;
            await _companyWriteRepository.SaveAsync();
            return new();

        }
    }
}
