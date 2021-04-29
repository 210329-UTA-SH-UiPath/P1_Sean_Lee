using System.Xml.Serialization;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Toppings;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>

  [XmlInclude(typeof(CheeseTopping))]
  [XmlInclude(typeof(MeatTopping))]
  [XmlInclude(typeof(VeggieTopping))]
  [XmlInclude(typeof(Crust))]
  [XmlInclude(typeof(Size))]

  public class ACustomizable
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}