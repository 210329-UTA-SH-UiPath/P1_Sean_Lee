using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class SmallSize : Size
  {
    public SmallSize()
    {
      Price = 0.00M;
      Name = "Small (8')";
    }

  }
}