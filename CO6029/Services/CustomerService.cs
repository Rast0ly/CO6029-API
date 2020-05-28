using CO6029.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Services
{
    public class CustomerService : ICustomerService
    {


        private readonly ICustomerRepository _customerRepository;


        public CustomerService(ICustomerRepository customerRepo)
        {
            _customerRepository = customerRepo;


        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _customerRepository.GetCustomerByIdAsync(id);


        }

        public async Task<IList<Customer>> GetAllCustomersAsync()
        {
            return await _customerRepository.GetAllCustomersAsync();
        }
    }
}
