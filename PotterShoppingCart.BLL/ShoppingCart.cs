using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.BLL
{
    public class ShoppingCart
    {
        private decimal _price = 100;

        public decimal CalTotalAmount(IDictionary<string, int> buyItem)
        {
            IDictionary<string, int> itemCnt = new Dictionary<string, int>();
            decimal totalAmt = 0;


            foreach (var item in buyItem)
            {
                if (itemCnt.ContainsKey(item.Key))
                {
                    itemCnt[item.Key] += itemCnt[item.Key];
                }
                else
                {
                    itemCnt.Add(item.Key, item.Value);
                }
            }

            foreach (var item in itemCnt)
            {
                if (itemCnt.Count == 1)
                {
                    totalAmt += item.Value * _price;
                }
                else if (itemCnt.Count == 2)
                {
                    totalAmt += item.Value * _price * (decimal)0.95;
                }
                else if (itemCnt.Count == 3)
                {
                    totalAmt += item.Value * _price * (decimal)0.9;
                }
                else
                {
                    totalAmt += item.Value * _price;
                }
            }

            return totalAmt;
        }
    }
}
