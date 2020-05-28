using Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Data
{
    public interface ICustomerRepository
    {

        Task<IList<CustomerModel>> GetAllCustomersAsync();
        Task<CustomerModel> GetCustomerByIdAsync(int id);
    }
}
