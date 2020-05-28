using Client.Data;
using Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Services
{
    public class CustomerService : ICustomerService
    {


        private readonly ICustomerRepository _customerRepository;


        public CustomerService(ICustomerRepository customerRepo)
        {
            _customerRepository = customerRepo;


        }

        public async Task<CustomerModel> GetCustomerByIdAsync(int id)
        {
            return await _customerRepository.GetCustomerByIdAsync(id);


        }

        public async Task<IList<CustomerModel>> GetAllCustomersAsync()
        {
            return await _customerRepository.GetAllCustomersAsync();
        }
    }
}
