using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class CrustTest
    {
        //arrange
        Crust c = new Crust
        {
            Id = 1,
            Name = "Buttery Crust",
            Price = 2.99M
        };

        [Fact]
        public void Test_CrustName()
        {
            //act
            var sut = c.Name;

            //assert
            Assert.True(sut.Equals("Buttery Crust"));
        }
        [Fact]
        public void Test_CrustId()
        {
            //act
            var sut = c.Id;

            //assert
            Assert.True(sut == 1);
        }
        [Fact]
        public void Test_CrustPrice()
        {
            //act
            var sut = c.Price;

            //assert
            Assert.True(sut == 2.99M);
        }
    }
}
