using FirmaSiparişYonetim.Application.Features.Commands.Orders.CreateOrder;
using FirmaSiparişYonetim.Application.Repositories.Orders;

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirmaSiparişYonetim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly IMediator _mediator;

        public OrderController(IOrderWriteRepository orderWriteRepository, IMediator mediator)
        {
            _orderWriteRepository = orderWriteRepository;
            this._mediator = mediator;            
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateOrderCommandRequest createOrderCommandRequest)
        {
            CreateOrderCommandResponse response = await _mediator.Send(createOrderCommandRequest);

            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
