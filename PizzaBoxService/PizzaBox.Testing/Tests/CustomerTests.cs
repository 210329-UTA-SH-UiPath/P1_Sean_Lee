using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{

  public class CustomerTests
  {
        Cust c = new Cust
        {
            Id = 2,
            Name = "Billy",
            Password = "Password123"
        };
    [Fact]
    public void Test_CustomerName()
    {
      // act
      var sut = c.Name;

      // assert
      Assert.Equal(sut, "Billy");
    }
        [Fact]
    public void Test_CustomerId()
    {
            var sut = c.Id;

      // assert
      Assert.Equal(sut, 2);
    }
        [Fact]
        public void Test_CustomerPassword()
        {
            var sut = c.Password;
            Assert.Equal(sut, "Password123");

        }
  }
}