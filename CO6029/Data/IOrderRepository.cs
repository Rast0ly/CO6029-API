using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Data
{
    public interface IOrderRepository
    {

        Task<IList<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderByIdAsync(int id);
    }
}
