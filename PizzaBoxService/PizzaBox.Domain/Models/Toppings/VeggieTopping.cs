using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class VeggieTopping : Topping
  {
    public VeggieTopping()
    {
      Price = 1.00M;
    }
  }
}