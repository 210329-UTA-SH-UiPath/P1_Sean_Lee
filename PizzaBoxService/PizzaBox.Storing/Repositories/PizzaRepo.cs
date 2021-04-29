using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepo : IRepository<Pizza>
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly PizzaMapper mapper = new PizzaMapper();
    public PizzaRepo(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public void Add(Pizza t)
    {
      if (t != null)
      {
        context.Pizzas.Add(mapper.Map(t));
        context.SaveChanges();
      }
    }

    public List<Pizza> GetList()
    {
      var x = context.Pizzas;
      return x.Select(mapper.Map).ToList();
    }

    public Pizza GetById(int id)
    {
      var x = context.Pizzas.Where(x => x.Id == id).FirstOrDefault();
      if (x != null)
      {
        return mapper.Map(x);
      }
      else
      {
        return null;
      }
    }

        public void Remove(int id)
        {
            var x = context.Pizzas.SingleOrDefault(s => s.Id == id);
            if (x != null)
            {
                context.Remove(x);
                context.SaveChanges();
            }
        }

        public void Update(Pizza t)
        {
            var record = context.Pizzas.Where(x => x.Id == x.Id).FirstOrDefault();
            if (record != null)
            {
                record.Name = t.Name;
                record.Price = t.Price;
                context.SaveChanges();
            }
        }
    }
}