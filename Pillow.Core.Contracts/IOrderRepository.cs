using Pillow.Core.Entites;

namespace Pillow.Core.Contracts
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
