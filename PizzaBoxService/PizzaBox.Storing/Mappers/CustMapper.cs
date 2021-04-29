using mCust = PizzaBox.Domain.Models.Cust;
using eCust = PizzaBox.Storing.Entities.Cust;


namespace PizzaBox.Storing.Mappers
{
  public class CustMapper : IMapper<mCust, eCust>
  {
    public mCust Map(eCust cust)
    {
      return new mCust
      {
        Id = cust.Id,
        Name = cust.Name,
        Password = cust.Password
      };
    }
    public eCust Map(mCust cust)
    {
      return new eCust
      {
        Id = cust.Id,
        Name = cust.Name,
        Password = cust.Password
      };
    }
  }
}