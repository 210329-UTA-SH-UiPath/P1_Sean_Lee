using mTopping = PizzaBox.Domain.Models.Topping;
using eTopping = PizzaBox.Storing.Entities.Topping;


namespace PizzaBox.Storing.Mappers
{
  public class ToppingMapper : IMapper<mTopping, eTopping>
  {
    public mTopping Map(eTopping topping)
    {
      return new mTopping
      {
        Id = topping.Id,
        Name = topping.Name,
        Price = topping.Price
      };
    }
    public eTopping Map(mTopping topping)
    {
      return new eTopping
      {
        Id = topping.Id,
        Name = topping.Name,
        Price = topping.Price
      };
    }
  }
}