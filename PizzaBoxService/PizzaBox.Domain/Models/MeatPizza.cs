using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class MeatPizza : APizza
  {
    public MeatPizza()
    {
      Name = "Speciality Meat Pizza";
      Price = 11.00M;
    }
    public override void AddToppings()
    {
      Toppings.Add(new MeatTopping());
      Toppings.Add(new MeatTopping());
    }
  }
}
