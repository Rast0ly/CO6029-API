using CO6029.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CO6029.Services
{
    public class OrderService : IOrderService
    {


        private readonly IOrderRepository _orderRepository;


        public OrderService(IOrderRepository orderRepo)
        {
            _orderRepository = orderRepo;


        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _orderRepository.GetOrderByIdAsync(id);


        }

        public async Task<IList<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync();
        }
    }
}
