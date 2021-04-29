using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class StoreRepo : IRepository<Store>
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly StoreMapper mapper = new StoreMapper();
    public StoreRepo(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public void Add(Store t)
    {
      if (t != null)
      {
        context.Stores.Add(mapper.Map(t));
        context.SaveChanges();
      }
    }

    public List<Store> GetList()
    {
      var x = context.Stores.Select(mapper.Map).ToList();
      return x;
    }

    public Store GetById(int id
    )
    {
      var t = context.Stores.Where(x => x.Id == id).FirstOrDefault();
      if (t != null)
      {
        return mapper.Map(t);
      }
      else
      {
        return null;
      }
    }

        public void Remove(int id)
        {
            var x = context.Stores.SingleOrDefault(s => s.Id == id);
            if (x != null)
            {
                context.Remove(x);
                context.SaveChanges();
            }
        }

        public void Update(Store t)
        {
            var record = context.Stores.Where(x => x.Id == x.Id).FirstOrDefault();
            if (record != null)
            {
                record.Name = t.Name;
                context.SaveChanges();
            }
        }

    }
}