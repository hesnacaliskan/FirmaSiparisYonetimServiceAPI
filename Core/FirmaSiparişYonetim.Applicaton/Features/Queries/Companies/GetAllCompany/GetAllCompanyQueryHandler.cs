using AutoMapper;
using FirmaSiparişYonetim.Application.Repositories.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Queries.Companies.GetAllCompany
{
    public class GetAllCompanyQueryHandler : IRequestHandler<GetAllCompanyQueryRequest, List<GetAllCompanyQueryResponse>>
    {
        readonly ICompanyReadRepository _companyReadRepository;
        IMapper _mapper;

        public GetAllCompanyQueryHandler(ICompanyReadRepository companyReadRepository, IMapper mapper)
        {
            _companyReadRepository = companyReadRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllCompanyQueryResponse>> Handle(GetAllCompanyQueryRequest request, CancellationToken cancellationToken)
        {            
            var companies = _companyReadRepository.GetAll();           
            return _mapper.Map<List<GetAllCompanyQueryResponse>>(companies);
            //return new();
        }
    }
}
