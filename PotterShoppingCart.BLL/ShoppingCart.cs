using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.BLL
{
    public class ShoppingCart
    {
        private decimal _price = 100;

        public decimal CalTotalAmount(int quantity)
        {
            return quantity * _price;
        }
    }
}
