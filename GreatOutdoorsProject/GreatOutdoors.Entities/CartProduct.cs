using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.Entities
{
    class CartProduct
    {
      
        public int CartId { get; set; } //ID of the cart
        public int ProductID { get; set; } //ID of the product
        public int ProductQuantityOrdered { get; set; }//quantity of the product ordered
        public double ProductPrice { get; set; }//price of the product
        public int TotalAmount { get; set; } //Cart value
        public List<int> cart = new List<int>();//List of product ID's
    }
}
