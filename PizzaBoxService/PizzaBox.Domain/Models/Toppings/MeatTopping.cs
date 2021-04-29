using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Toppings
{
  public class MeatTopping : Topping
  {
    public MeatTopping()
    {
      Price = 2.00M;
    }
  }
}