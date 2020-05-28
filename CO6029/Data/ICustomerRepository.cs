using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Data
{
    public interface ICustomerRepository
    {

        Task<IList<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
    }
}
