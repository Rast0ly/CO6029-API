using CO6029.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Services
{
    public interface ICustomerService
    {

        Task<IList<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
    }
}
