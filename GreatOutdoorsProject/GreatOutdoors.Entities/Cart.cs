using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.Entities
{
    public class Cart
    {
        public int CartId { get; set; } //ID of the cart
        public int AddressID { get; set; } //address ID of the retailer 
        public int RetailerID { get; set; } //ID of the retailer
        public int ProductID { get; set; } //ID of the product
        public int TotalQuantity { get; set; } //Total quantity of the products ordererd
        public int TotalAmount { get; set; } //Cart value
    }
}
