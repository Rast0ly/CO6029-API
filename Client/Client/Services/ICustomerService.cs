using Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Services
{
    public interface ICustomerService
    {

        Task<IList<CustomerModel>> GetAllCustomersAsync();
        Task<CustomerModel> GetCustomerByIdAsync(int id);
    }
}
