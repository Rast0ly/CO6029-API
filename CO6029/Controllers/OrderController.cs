using Api.Models.Orders;
using CO6029.Modles;
using CO6029.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CO6029.Controllers
{
    [Route("api/Orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {

            _orderService = orderService;

        }

        [HttpGet(Name = nameof(GetAlOrders))]
        public async Task<IActionResult> GetAlOrders()

        {

            var orders = await _orderService.GetAllOrdersAsync();


            return Ok(orders.ToModel());

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order.ToModel());
        }








    }
}