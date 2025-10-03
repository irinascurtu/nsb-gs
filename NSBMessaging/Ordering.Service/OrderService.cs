using AutoMapper;
using Ordering.Data;
using Ordering.Domain.Entities;

namespace Ordering.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper
            )
        {
            _orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await _orderRepository.GetOrdersAsync();
        }

        public async Task<Order> GetOrderAsync(int id)
        {
            return await _orderRepository.GetOrderAsync(id);
        }

        public async Task<Order> GetOrderAsync(Guid orderId)
        {
            return await _orderRepository.GetOrderAsync(orderId);
        }

        public async Task<Order> AddOrderAsync(Order order)
        {
            return await _orderRepository.AddOrderAsync(order);
        }

        public async Task<int> UpdateOrderAsync(Order order)
        {
            return await _orderRepository.UpdateOrderAsync(order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _orderRepository.DeleteOrderAsync(id);
        }

        public async Task<bool> OrderExistsAsync(int id)
        {
            return await _orderRepository.OrderExistsAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _orderRepository.SaveChangesAsync();
        }


    }
}
