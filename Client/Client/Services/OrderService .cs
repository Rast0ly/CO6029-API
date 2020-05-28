using Client.Data;
using Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Services
{
    public class OrderService : IOrderService
    {


        private readonly IOrderRepository _orderRepository;


        public OrderService(IOrderRepository orderRepo)
        {
            _orderRepository = orderRepo;


        }

        public async Task<OrderModel> GetOrderByIdAsync(int id)
        {
            return await _orderRepository.GetOrderByIdAsync(id);


        }

        public async Task<IList<OrderModel>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync();
        }
    }
}
