using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class Repository
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly Mapper mapper = new Mapper();
    public Repository(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public List<Crust> GetAllCrusts()
    {
      var crusts = context.Crusts;
      return crusts.Select(mapper.Map).ToList();
    }
    public List<Pizza> GetAllPizzas()
    {
      var pizzas = context.Pizzas;
      return pizzas.Select(mapper.Map).ToList();
    }
    public List<Size> GetAllSizes()
    {
      var sizes = context.Sizes;
      return sizes.Select(mapper.Map).ToList();
    }
    public List<Store> GetAllStores()
    {
      var stores = context.Stores;
      return stores.Select(mapper.Map).ToList();
    }
    public List<Topping> GetAllToppings()
    {
      var toppings = context.Toppings;
      return toppings.Select(mapper.Map).ToList();
    }
    public List<CustOrder> GetAllOrders()
    {
      var orders = context.CustOrders;
      return orders.Select(mapper.Map).ToList();
    }
    public Cust GetCustomerById(int id)
    {
      var cust = context.Custs.Where(c => c.Id == id).FirstOrDefault();
      if (cust != null)
      {
        return mapper.Map(cust);
      }
      else
      {
        return null;
      }
    }
    public void AddCustomer(Cust c)
    {
      if (c != null)
      {
        context.Add(mapper.Map(c));
        context.SaveChanges();
      }
    }
    public void AddPizzaOrder(CustOrder o)
    {
      if (o != null)
      {
        context.Add(mapper.Map(o));
        context.SaveChanges();
      }
    }


  }
}