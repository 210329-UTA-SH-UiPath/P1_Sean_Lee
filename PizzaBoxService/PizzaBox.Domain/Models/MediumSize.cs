using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class MediumSize : Size
  {
    public MediumSize()
    {
      Price = 5.00M;
      Name = "Medium (12')";
    }

  }
}