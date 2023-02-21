using FirmaSiparişYonetim.Application.Features.Commands.Companies.CreateCompany;
using FirmaSiparişYonetim.Application.Features.Commands.Companies.UpdateCompany;
using FirmaSiparişYonetim.Application.Features.Queries.Companies.GetAllCompany;
using FirmaSiparişYonetim.Application.Repositories.Companies;
using FirmaSiparişYonetim.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirmaSiparişYonetim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        readonly private ICompanyReadRepository _companyReadRepository;
        readonly private ICompanyWriteRepository _companyWriteRepository;
        readonly IMediator _mediator;

        public CompanyController(ICompanyReadRepository companyReadRepository, ICompanyWriteRepository companyWriteRepository, IMediator mediator)
        {
            _companyReadRepository = companyReadRepository;
            _companyWriteRepository = companyWriteRepository;
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllCompanyQueryResponse>> Get()
        {            
            return await _mediator.Send(new GetAllCompanyQueryRequest());
            //return Ok(_companyReadRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCompanyCommandRequest createCompanyCommandRequest)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(createCompanyCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCompanyCommandRequest updateCompanyCommandRequest)
        {
            UpdateCompanyCommandResponse response = await _mediator.Send(updateCompanyCommandRequest);
            return Ok();
        }
    }
}
