using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{
    public class PizzaOrderRepo
    {
        private readonly Entities.HeroesAppSeanContext context;
        private readonly PizzaOrderMapper mapper = new PizzaOrderMapper();
        public PizzaOrderRepo(Entities.HeroesAppSeanContext context)
        {
            this.context = context;
        }

        public void Add(PizzaOrder t)
        {
            if (t != null)
            {
                context.PizzaOrders.Add(mapper.Map(t));
                context.SaveChanges();
            }
        }

        public List<PizzaOrder> GetList()
        {
            var x = context.PizzaOrders;
            return x.Select(mapper.Map).ToList();
        }

        public List<PizzaOrder> GetByOrderPizzaId(int orderId, int pizzaId)
        {
            var x = context.PizzaOrders.Where(x =>
            orderId == x.OrderId && pizzaId == x.PizzaId);
            if (x != null)
            {
                //return mapper.Map(x);
                return x.Select(mapper.Map).ToList();
            }
            else
            {
                return null;
            }

            //var x = context.PizzaOrders.Include(o => o.Order).Include(o => o.Pizza).Include(o => o.Size).Include(p => p.Topping)
            //        .Where(x => x.OrderId == orderId && x.PizzaId == pizzaId).FirstOrDefault();
            //if (x != null)
            //{

            //    return mapper.Map(x);
            //}
            //else
            //{
            //    return null;
            //}

        }
        //public void Remove(int id)
        //{
        //    var x = context.PizzaOrders.SingleOrDefault(s => s.Id == id);
        //    if (x != null)
        //    {
        //        context.Remove(x);
        //        context.SaveChanges();
        //    }
        //}

        //public void Update(PizzaOrder t)
        //{
        //    var record = context.PizzaOrders.Where(x => x.Id == x.Id).FirstOrDefault();
        //    if (record != null)
        //    {
        //        record.OrderId = t.OrderId;
        //        record.PizzaId = t.PizzaId;
        //        record.SizeId = t.SizeId;
        //        record.ToppingId1 = t.ToppingId1;
        //        record.ToppingId2 = t.ToppingId2;
        //        record.ToppingId3 = t.ToppingId3;
        //        record.ToppingId4 = t.ToppingId4;
        //        record.ToppingId5 = t.ToppingId5;
        //        record.Price = t.Price;
        //        record.Quantity = t.Quantity;
        //        context.SaveChanges();
        //    }
        //}

    }
}