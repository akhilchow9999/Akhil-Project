using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.Entities
{
    class Order
    {
        public int OrderId { get; set; } //ID of the order
        public DateTime DateOfOrder { get; set; } //Date of placing order
        public int CartId { get; set; } //ID of the cart
        public List<int> cart = new List<int>();//List of product ID's

    }
}
