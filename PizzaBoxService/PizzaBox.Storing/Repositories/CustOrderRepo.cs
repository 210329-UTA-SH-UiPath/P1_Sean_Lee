using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
  public class CustOrderRepo
  {
    private readonly Entities.HeroesAppSeanContext context;
    private readonly CustOrderMapper mapper = new CustOrderMapper();
    public CustOrderRepo(Entities.HeroesAppSeanContext context)
    {
      this.context = context;
    }

    public void Add(CustOrder t)
    {
      if (t != null)
      {
        context.CustOrders.Add(mapper.Map(t));
        context.SaveChanges();
      }
    }

    public List<CustOrder> GetList()
    {
      var x = context.CustOrders;
      return x.Select(mapper.Map).ToList();
    }

    public CustOrder GetById(int id)
    {
      var x = context.CustOrders.Where(x => x.Id == id).FirstOrDefault();
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
            var x = context.CustOrders.SingleOrDefault(s => s.Id == id);
            if (x != null)
            {
                context.Remove(x);
                context.SaveChanges();
            }
        }

        //public void Update(CustOrder t)
        //{
        //    var record = context.CustOrders.Where(x => x.Id == x.Id).FirstOrDefault();
        //    if (record != null)
        //    {
        //        record.PurchaseDate = t.PurchaseDate;
        //        record.Price = t.Price;
        //        record.CustomerId = t.CustomerId;
        //        record.StoreId = t.StoreId;
        //        context.Update(record);
        //        context.SaveChanges();
        //    }
        //}
        public void UpdateOrderPrice(int id, decimal price)
        {
            var record = context.CustOrders.Where(x => x.Id == id).FirstOrDefault();
            if (record != null)
            {
                record.Price = price;
                context.Update(record);
                context.SaveChanges();
            }
        }

    }
}