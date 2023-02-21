using AutoMapper;
using FirmaSiparişYonetim.Application.Features.Queries.Companies.GetAllCompany;
using FirmaSiparişYonetim.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureApp.Application.Mapping
{
    public class GeneralMapping: Profile
    {

        public GeneralMapping()
        {
            CreateMap<Company, GetAllCompanyQueryResponse>()
                .ReverseMap();

        }

    }
}
