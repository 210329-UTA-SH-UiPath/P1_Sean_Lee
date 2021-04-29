using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class LargeSize : Size
  {
    public LargeSize()
    {
      Price = 9.00M;
      Name = "Large (16')";
    }

  }
}