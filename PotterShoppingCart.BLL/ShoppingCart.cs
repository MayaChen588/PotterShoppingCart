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
                if (item.Value > 0)
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
            }

            while (itemCnt.Count > 0)
            {
                foreach (var item in itemCnt)
                {
                    if (itemCnt.Count == 1)
                    {
                        totalAmt += _price;
                    }
                    else if (itemCnt.Count == 2)
                    {
                        totalAmt += _price * (decimal)0.95;
                    }
                    else if (itemCnt.Count == 3)
                    {
                        totalAmt += _price * (decimal)0.9;
                    }
                    else if (itemCnt.Count == 4)
                    {
                        totalAmt += _price * (decimal)0.8;
                    }
                    else if (itemCnt.Count == 5)
                    {
                        totalAmt += _price * (decimal)0.75;
                    }
                    else
                    {
                        totalAmt += _price;
                    }
                }

                foreach (var key in itemCnt.Keys.ToList())
                {
                    itemCnt[key] -= 1;

                    if (itemCnt[key] == 0)
                    {
                        itemCnt.Remove(key);
                    }
                }
            }


            return totalAmt;
        }
    }
}
