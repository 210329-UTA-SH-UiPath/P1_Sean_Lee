using mo = PizzaBox.Domain.Models.CustOrder;
using eo = PizzaBox.Storing.Entities.CustOrder;


namespace PizzaBox.Storing.Mappers
{
  public class CustOrderMapper : IMapper<mo, eo>
  {
    public mo Map(eo order)
    {
      return new mo
      {
        Id = order.Id,
        PurchaseDate = order.PurchaseDate,
        Price = order.Price,
        CustomerId = order.CustomerId,
        StoreId = order.StoreId
      };
    }
    public eo Map(mo order)
    {
      return new eo
      {
        Id = order.Id,
        PurchaseDate = order.PurchaseDate,
        Price = order.Price,
        CustomerId = order.CustomerId,
        StoreId = order.StoreId
      };
    }
  }
}