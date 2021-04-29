using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{

  public class CustomerTests
  {
    [Fact]
    public void Test_CustomerName()
    {
      // arrange
      var sut = new Cust();
      sut.Name = "Billy";

      // act
      var actual = sut.Name;

      // assert
      Assert.Equal(actual, "Billy");
    }
    public void Test_CustomerId()
    {
      var sut = new Cust();
      sut.Id = 1;

      // act
      var actual = sut.Id;

      // assert
      Assert.Equal(actual, 1);
    }
  }
}