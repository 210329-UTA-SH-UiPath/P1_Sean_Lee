using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class DeepDishCrust : Crust
  {
    public DeepDishCrust()
    {
      Name = "Chicago Deep Dish";
      Price = 3.00M;
    }
  }
}