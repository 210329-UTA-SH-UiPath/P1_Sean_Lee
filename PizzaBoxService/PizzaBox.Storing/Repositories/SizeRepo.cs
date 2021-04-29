using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class SizeRepo : IRepository<Size>
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly SizeMapper mapper = new SizeMapper();
    public SizeRepo(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public void Add(Size t)
    {
      if (t != null)
      {
        context.Sizes.Add(mapper.Map(t));
        context.SaveChanges();
      }
    }

    public List<Size> GetList()
    {
      var x = context.Sizes;
      return x.Select(mapper.Map).ToList();
    }

    public Size GetById(int id)
    {
      var x = context.Sizes.Where(x => x.Id == id).FirstOrDefault();
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
            var x = context.Sizes.SingleOrDefault(s => s.Id == id);
            if (x != null)
            {
                context.Remove(x);
                context.SaveChanges();
            }
        }

        public void Update(Size t)
        {
            var record = context.Sizes.Where(x => x.Id == x.Id).FirstOrDefault();
            if (record != null)
            {
                record.Name = t.Name;
                record.Price = t.Price;
                context.SaveChanges();
            }
        }
    }
}