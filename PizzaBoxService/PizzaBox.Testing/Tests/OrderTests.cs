using PizzaBox.Domain.Models;
using System;
using Xunit;

namespace PizzaBox.Testing.Tests
{

  public class OrderTests
  {
        static DateTime now = DateTime.Now;
        CustOrder c = new CustOrder
        {
            Id = 1,
            PurchaseDate = now,
            Price = 10.00M,
            CustomerId = 2,
            StoreId = 3
        };

        [Fact]
        public void Test_OrderId()
        {
            //act
            var sut = c.Id;

            //assert
            Assert.True(sut == 1);
        }
        [Fact]
        public void Test_OrderDate()
        {
            //act
            var sut = c.PurchaseDate;

            //assert
            Assert.True(sut == now);
        }
        [Fact]
        public void Test_Price()
        {
            //act
            var sut = c.Price;

            //assert
            Assert.True(sut == 10.00M);
        }
        [Fact]
        public void Test_CustomerId()
        {
            //act
            var sut = c.CustomerId;

            //assert
            Assert.True(sut == 2);
        }
        [Fact]
        public void Test_StoreId()
        {
            //act
            var sut = c.StoreId;

            //assert
            Assert.True(sut == 3);
        }
    }
}