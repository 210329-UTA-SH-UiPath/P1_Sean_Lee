using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class CheeseStuffCrust : Crust
  {
    public CheeseStuffCrust()
    {
      Name = "Stuffed Crusted";
      Price = 5.00M;
    }
  }
}