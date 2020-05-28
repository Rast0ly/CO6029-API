using Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Data
{
    public interface IOrderRepository
    {

        Task<IList<OrderModel>> GetAllOrdersAsync();
        Task<OrderModel> GetOrderByIdAsync(int id);
    }
}
