using mSize = PizzaBox.Domain.Models.Size;
using eSize = PizzaBox.Storing.Entities.Size;


namespace PizzaBox.Storing.Mappers
{
  public class SizeMapper : IMapper<mSize, eSize>
  {
    public mSize Map(eSize size)
    {
      return new mSize
      {
        Id = size.Id,
        Name = size.Name,
        Price = size.Price
      };
    }
    public eSize Map(mSize size)
    {
      return new eSize
      {
        Id = size.Id,
        Name = size.Name,
        Price = size.Price
      };
    }
  }
}