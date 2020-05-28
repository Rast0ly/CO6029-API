using CO6029.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Services
{
    public interface IOrderService
    {

        Task<IList<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
    }
}
