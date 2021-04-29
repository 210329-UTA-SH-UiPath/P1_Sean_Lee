using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class NewYorkStyleCrust : Crust
  {
    public NewYorkStyleCrust()
    {
      Name = "New York Style Crust";
      Price = 2.00M;
    }
  }
}