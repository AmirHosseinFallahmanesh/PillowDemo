using Pillow.Core.Contracts;
using Pillow.Core.Entites;

namespace Pillow.Core.ApplicationService
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }


        public void SaveOrder(Order order)
        {
            orderRepository.Save(order);
        }
    }
}
