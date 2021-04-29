using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class PlainPizza : APizza
  {
    public PlainPizza()
    {
      Name = "Plain Pizza";
      Price = 7.00M;
    }
  }
}