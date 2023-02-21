using FirmaSiparişYonetim.Application.Abstractions.Hubs;
using FirmaSiparişYonetim.Application.Repositories.Companies;
using FirmaSiparişYonetim.Application.Repositories.Orders;
using FirmaSiparişYonetim.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparişYonetim.Application.Features.Commands.Orders.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        readonly IOrderWriteRepository _orderWriteRepository;
        readonly ICompanyReadRepository _companyReadRepository;
        //readonly IOrderHubService _orderHubService;



        public CreateOrderCommandHandler(IOrderWriteRepository orderWriteRepository, ICompanyReadRepository companyReadRepository )
        {
            _orderWriteRepository = orderWriteRepository;
            _companyReadRepository = companyReadRepository;
            //_orderHubService = orderHubService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var siparisBaslangic = _companyReadRepository.Table.Select(c => c.SiparisBaslangic);
            var siparisBitis = _companyReadRepository.Table.Select(c => c.SiparisBitis);
            var onayDurumu = _companyReadRepository.Table.Select(c => c.OnayDurumu);
            var simdikiZaman = DateTime.UtcNow.Hour.ToString();

            while (onayDurumu.Equals("Onaylı"))
            {
                if(simdikiZaman.CompareTo(siparisBaslangic) == 1 && simdikiZaman.CompareTo(siparisBitis) == -1)
                {
                    await _orderWriteRepository.AddAsync(new()
                    {
                        Name = request.Name,
                        firmaId = request.firmaId,
                        urunId = request.urunId,
                        CreatedTime = DateTime.UtcNow,
                    }); ;
                    await _orderWriteRepository.SaveAsync();
                    //await _orderHubService.OrderAddedMessageAsync("Sipariş başarıyla alındıı ! :) ");
                }
                else
                {
                    //await _orderHubService.OrderAddedMessageAsync("Bu saat aralığında firma sipariş almamaktadır.");
                }
            }
            
            if(onayDurumu.Equals("Onaylı Değil"))
            {
                //await _orderHubService.OrderAddedMessageAsync("Sipariş firma onaylı olmadığı için gerçekleştirilememiştir!");
            }
            

            return new();
        }
    }
}
