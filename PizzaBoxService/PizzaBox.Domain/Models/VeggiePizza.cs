using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class VeggiePizza : APizza
  {
    public VeggiePizza()
    {
      Name = "Specialty Veggie Pizza";
      Price = 9.00M;
    }
    public override void AddToppings()
    {
      Toppings.Add(new VeggieTopping());
      Toppings.Add(new VeggieTopping());
    }
  }
}