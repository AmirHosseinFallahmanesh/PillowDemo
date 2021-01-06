using Pillow.Core.Contracts;
using Pillow.Core.Entites;
using Pillow.Infrastruture.Sql;
using System.Linq;

namespace Pillow.Infrastruture.Data
{
    public class OrederRepository: IOrderRepository
    {
        private readonly DemoContext context;

        public OrederRepository(DemoContext context)
        {
            
            this.context = context;
        }

        public void Save(Order order)
        {
            context.AttachRange(order.Lines.Select(a => a.Product));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
