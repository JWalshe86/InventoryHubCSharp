using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryHub
{
    public class DiscountedProduct : Product
    {
        public decimal Discount { get; set; }

        public DiscountedProduct(int id, string name, decimal price, decimal discount)
            : base(id, name, price)
        {
            Discount = discount;
        }

        public decimal GetDiscountedPrice()
        {
            return Price - (Price * Discount / 100);
        }
    }

}
