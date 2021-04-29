using mCrust = PizzaBox.Domain.Models.Crust;
using eCrust = PizzaBox.Storing.Entities.Crust;


namespace PizzaBox.Storing.Mappers
{
  public class CrustMapper : IMapper<mCrust, eCrust>
  {
    public mCrust Map(eCrust crust)
    {
      return new mCrust
      {
        Id = crust.Id,
        Name = crust.Name,
        Price = crust.Price
      };
    }
    public eCrust Map(mCrust crust)
    {
      return new eCrust
      {
        Id = crust.Id,
        Name = crust.Name,
        Price = crust.Price
      };
    }
  }
}