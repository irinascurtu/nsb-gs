using Contracts.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ordering.Api.Models;
using Ordering.Domain.Entities;

namespace Ordering.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMessageSession messageSession;

        public OrdersController(IMessageSession messageSession)
        {
            this.messageSession = messageSession;
        }


        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(OrderModel model)
        {
            await messageSession.Send(new CreateOrder
            {
                OrderId = model.OrderId
            });

            return Accepted();
        }
    }
}