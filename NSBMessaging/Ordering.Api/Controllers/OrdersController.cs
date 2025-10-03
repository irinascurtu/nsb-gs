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
        public OrdersController()
        {

        }


        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(OrderModel model)
        {
            return Accepted();
        }
    }
}