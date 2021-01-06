using System;
using System.Collections.Generic;

namespace Pillow.Core.Entites
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<CartLine> Lines { get; set; }

        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
