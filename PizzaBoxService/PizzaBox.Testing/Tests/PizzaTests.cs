using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  /// <summary>
  /// 
  /// </summary>
  public class PizzaTests
  {
        /// <summary>
        /// 
        /// </summary>
        Pizza p = new Pizza
        {
            Id = 1,
            Name = "Pepperoni",
            Price = 25.00M
        };
        [Fact]
        public void Test_PizzaName()
        {
            //act
            var sut = p.Name;

            //assert
            Assert.True(sut.Equals("Pepperoni"));
        }
        [Fact]
        public void Test_CrustId()
        {
            //act
            var sut = p.Id;

            //assert
            Assert.True(sut == 1);
        }
        [Fact]
        public void Test_CrustPrice()
        {
            //act
            var sut = p.Price;

            //assert
            Assert.True(sut == 25.00M);
        }
    }
}
