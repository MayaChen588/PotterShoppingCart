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
            var expented = 100;
            var actual = target.CalTotalAmount(1);
            // assert

            Assert.AreEqual(expented, actual);
        }

        [TestMethod()]
        public void Test_購買二本價格應為190元()
        {
            // arrange
            var target = new ShoppingCart();

            // act
            var expented = 190;
            var actual = target.CalTotalAmount(2);
            // assert

            Assert.AreEqual(expented, actual);
        }
    

    }
}
