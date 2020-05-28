using CO6029.Modles;
using CO6029.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CO6029.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {

            _customerService = customerService;

        }

        [HttpGet(Name = nameof(GetAlCustomers))]
        public async Task<IActionResult> GetAlCustomers()

        {

            var customers = await _customerService.GetAllCustomersAsync();


            return Ok(customers.ToModel());

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer.ToModel());
        }








    }
}