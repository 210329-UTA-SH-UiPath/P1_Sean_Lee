using mCrust = PizzaBox.Domain.Models.Crust;
using eCrust = PizzaBox.Storing.Entities.Crust;
using mPizza = PizzaBox.Domain.Models.Pizza;
using ePizza = PizzaBox.Storing.Entities.Pizza;
using mTopping = PizzaBox.Domain.Models.Topping;
using eTopping = PizzaBox.Storing.Entities.Topping;
using mSize = PizzaBox.Domain.Models.Size;
using eSize = PizzaBox.Storing.Entities.Size;
using mc = PizzaBox.Domain.Models.Cust;
using ec = PizzaBox.Storing.Entities.Cust;
using ms = PizzaBox.Domain.Models.Store;
using es = PizzaBox.Storing.Entities.Store;
using mo = PizzaBox.Domain.Models.CustOrder;
using eo = PizzaBox.Storing.Entities.CustOrder;

namespace PizzaBox.Storing.Mappers
{
  public class Mapper
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
    public mc Map(ec customer)
    {
      return new mc
      {
        Id = customer.Id,
        Name = customer.Name,
        Password = customer.Password
      };
    }
    public ec Map(mc customer)
    {
      return new ec
      {
        Id = customer.Id,
        Name = customer.Name,
        Password = customer.Password
      };
    }
    public ms Map(es store)
    {
      return new ms
      {
        Id = store.Id,
        Name = store.Name
      };
    }
    public es Map(ms store)
    {
      return new es
      {
        Id = store.Id,
        Name = store.Name
      };
    }
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