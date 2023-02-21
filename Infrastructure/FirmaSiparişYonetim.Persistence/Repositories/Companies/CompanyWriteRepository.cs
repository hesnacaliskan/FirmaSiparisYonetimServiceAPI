using FirmaSiparişYonetim.Application.Repositories.Companies;
using FirmaSiparişYonetim.Domain.Entities;
using FirmaSiparişYonetim.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Persistence.Repositories.Companies
{
    public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(FirmaSiparisYonetimDbContext context) : base(context)
        {
        }
    }
}
