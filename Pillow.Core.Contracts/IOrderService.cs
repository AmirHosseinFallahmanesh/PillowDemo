using Pillow.Core.Entites;

namespace Pillow.Core.Contracts
{
    public interface IOrderService
    {
        void SaveOrder(Order order);
    }
}
