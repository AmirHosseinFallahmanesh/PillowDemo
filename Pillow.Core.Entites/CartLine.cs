using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Pillow.Core.Entites
{
    [NotMapped]
    public class CartLine
    {
      
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
