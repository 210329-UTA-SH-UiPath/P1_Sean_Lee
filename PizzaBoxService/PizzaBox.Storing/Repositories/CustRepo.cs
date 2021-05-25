using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class CustRepo
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly CustMapper mapper = new CustMapper();
    public CustRepo(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public void Add(Cust t)
    {
      if (t != null)
      {
        context.Custs.Add(mapper.Map(t));
        context.SaveChanges();
      }
    }

    public List<Cust> GetList()
    {
      var x = context.Custs;
      return x.Select(mapper.Map).ToList();
    }

    public Cust GetById(int id)
    {
      var x = context.Custs.Where(x => x.Id == id).FirstOrDefault();
      if (x != null)
      {
        return mapper.Map(x);
      }
      else
      {
        return null;
      }
    }

        public Cust GetByName(string name)
        {
            var x = context.Custs.Where(x => x.Name == name).FirstOrDefault();
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
            var x = context.Custs.SingleOrDefault(s => s.Id == id);
            if (x != null)
      {
        context.Remove(x);
        context.SaveChanges();
      }
    }

        public void Update(Cust t)
        {
            var record = context.Custs.Where(x => x.Id == x.Id).FirstOrDefault();
            if (record != null)
            {
                record.Name = t.Name;
                record.Password = t.Password;
                context.Update(record);
                context.SaveChanges();
            }
        }
    }
}