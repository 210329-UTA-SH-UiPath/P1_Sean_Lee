using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepo : IRepository<Crust>
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly CrustMapper mapper = new CrustMapper();
    public CrustRepo(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public void Add(Crust t)
    {
      if (t != null)
      {
        context.Crusts.Add(mapper.Map(t));
        context.SaveChanges();
      }
    }

    public List<Crust> GetList()
    {
      var x = context.Crusts;
      return x.Select(mapper.Map).ToList();
    }

    public Crust GetById(int id)
    {
      var x = context.Crusts.Where(x => x.Id == id).FirstOrDefault();
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
            var x = context.Crusts.SingleOrDefault(s => s.Id == id);
            if (x != null)
            {
                context.Remove(x);
                context.SaveChanges();
            }
        }

        public void Update(Crust t)
        {
            var record = context.Crusts.Where(x => x.Id == x.Id).FirstOrDefault();
            if (record != null)
            {
                record.Name = t.Name;
                record.Price = t.Price;
                context.SaveChanges();
            }
        }
    }

}
