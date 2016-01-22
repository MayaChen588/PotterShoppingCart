using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterShoppingCart.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PotterShoppingCart.BLL.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void Test_購買一本價格應為100元()
        {
            // arrange
            var target = new ShoppingCart();

            // act
            var expented = 100 * 1;
            IDictionary<string, int> buyItem = new Dictionary<string, int>();
            buyItem.Add("PotterBook-1", 1);

            var actual = target.CalTotalAmount(buyItem);
            // assert

            Assert.AreEqual(expented, actual);
        }

        [TestMethod()]
        public void Test_購買不同二本價格應為190元()
        {
            // arrange
            var target = new ShoppingCart();

            // act
            var expented = (decimal)(100 * 2 * 0.95);
            IDictionary<string, int> buyItem = new Dictionary<string, int>();
            buyItem.Add("PotterBook-1", 1);
            buyItem.Add("PotterBook-2", 1);
            var actual = target.CalTotalAmount(buyItem);
            // assert

            Assert.AreEqual(expented, actual);
        }

        [TestMethod()]
        public void Test_購買不同三本價格應為270元()
        {
            // arrange
            var target = new ShoppingCart();

            // act
            var expented = (decimal)(100 * 3 * 0.9);
            IDictionary<string, int> buyItem = new Dictionary<string, int>();
            buyItem.Add("PotterBook-1", 1);
            buyItem.Add("PotterBook-2", 1);
            buyItem.Add("PotterBook-3", 1);
            var actual = target.CalTotalAmount(buyItem);
            // assert

            Assert.AreEqual(expented, actual);
        }


        [TestMethod()]
        public void Test_購買不同四本價格應為320元()
        {
            // arrange
            var target = new ShoppingCart();

            // act
            var expented = (decimal)(100 * 4 * 0.8);
            IDictionary<string, int> buyItem = new Dictionary<string, int>();
            buyItem.Add("PotterBook-1", 1);
            buyItem.Add("PotterBook-2", 1);
            buyItem.Add("PotterBook-3", 1);
            buyItem.Add("PotterBook-4", 1);
            var actual = target.CalTotalAmount(buyItem);
            // assert

            Assert.AreEqual(expented, actual);
        }


        [TestMethod()]
        public void Test_購買不同五本價格應為375元()
        {
            // arrange
            var target = new ShoppingCart();

            // act
            var expented = (decimal)(100 * 5 * 0.75);
            IDictionary<string, int> buyItem = new Dictionary<string, int>();
            buyItem.Add("PotterBook-1", 1);
            buyItem.Add("PotterBook-2", 1);
            buyItem.Add("PotterBook-3", 1);
            buyItem.Add("PotterBook-4", 1);
            buyItem.Add("PotterBook-5", 1);
            var actual = target.CalTotalAmount(buyItem);
            // assert

            Assert.AreEqual(expented, actual);
        }


        [TestMethod()]
        public void Test_購買一二集各一本_第三集二本價格應為370元()
        {
            // arrange
            var target = new ShoppingCart();

            // act
            var expented = (decimal)(100 * 3 * 0.9 + 100);
            IDictionary<string, int> buyItem = new Dictionary<string, int>();
            buyItem.Add("PotterBook-1", 1);
            buyItem.Add("PotterBook-2", 1);
            buyItem.Add("PotterBook-3", 2);
            buyItem.Add("PotterBook-4", 0);
            buyItem.Add("PotterBook-5", 0);
            var actual = target.CalTotalAmount(buyItem);
            // assert

            Assert.AreEqual(expented, actual);
        }
    }
}
