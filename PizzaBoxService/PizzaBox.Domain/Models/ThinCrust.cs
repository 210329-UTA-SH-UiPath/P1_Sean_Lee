using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class ThinCrust : Crust
  {
    public ThinCrust()
    {
      Name = "Thin Crust";
      Price = 0.00M;
    }
  }
}