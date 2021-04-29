using mPizza = PizzaBox.Domain.Models.Pizza;
using ePizza = PizzaBox.Storing.Entities.Pizza;


namespace PizzaBox.Storing.Mappers
{
  public class PizzaMapper : IMapper<mPizza, ePizza>
  {
    public mPizza Map(ePizza pizza)
    {
      return new mPizza
      {
        Id = pizza.Id,
        Name = pizza.Name,
        Price = pizza.Price
      };
    }
    public ePizza Map(mPizza pizza)
    {
      return new ePizza
      {
        Id = pizza.Id,
        Name = pizza.Name,
        Price = pizza.Price
      };
    }
  }
}