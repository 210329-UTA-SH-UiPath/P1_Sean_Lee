using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepo : IRepository<Topping>
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly ToppingMapper mapper = new ToppingMapper();
    public ToppingRepo(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public void Add(Topping t)
    {
      if (t != null)
      {
        context.Toppings.Add(mapper.Map(t));
        context.SaveChanges();
      }
    }

    public List<Topping> GetList()
    {
      var x = context.Toppings;
      return x.Select(mapper.Map).ToList();
    }

    public Topping GetById(int id)
    {
      var x = context.Toppings.Where(x => x.Id == id).FirstOrDefault();
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
            var x = context.Toppings.SingleOrDefault(s => s.Id == id);
            if (x != null)
            {
                context.Remove(x);
                context.SaveChanges();
            }
        }

        public void Update(Topping t)
        {
            var record = context.Toppings.Where(x => x.Id == x.Id).FirstOrDefault();
            if (record != null)
            {
                record.Name = t.Name;
                record.Price = t.Price;
                context.SaveChanges();
            }
        }
    }
}