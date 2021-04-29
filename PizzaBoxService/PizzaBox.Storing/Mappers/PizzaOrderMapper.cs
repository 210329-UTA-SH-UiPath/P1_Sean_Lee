using mPizzaOrder = PizzaBox.Domain.Models.PizzaOrder;
using ePizzaOrder = PizzaBox.Storing.Entities.PizzaOrder;


namespace PizzaBox.Storing.Mappers
{
    public class PizzaOrderMapper : IMapper<mPizzaOrder, ePizzaOrder>
    {
        public mPizzaOrder Map(ePizzaOrder pizzaOrder)
        {
            return new mPizzaOrder
            {
                OrderId = pizzaOrder.OrderId,
                PizzaId = pizzaOrder.PizzaId,
                SizeId = pizzaOrder.SizeId,
                ToppingId1 = pizzaOrder.ToppingId1,
                ToppingId2 = pizzaOrder.ToppingId2,
                ToppingId3 = pizzaOrder.ToppingId3,
                ToppingId4 = pizzaOrder.ToppingId4,
                ToppingId5 = pizzaOrder.ToppingId5,
                Price = pizzaOrder.Price,
                Quantity = pizzaOrder.Quantity
            };
        }
        public ePizzaOrder Map(mPizzaOrder pizzaOrder)
        {
            return new ePizzaOrder
            {
                OrderId = pizzaOrder.OrderId,
                PizzaId = pizzaOrder.PizzaId,
                SizeId = pizzaOrder.SizeId,
                ToppingId1 = pizzaOrder.ToppingId1,
                ToppingId2 = pizzaOrder.ToppingId2,
                ToppingId3 = pizzaOrder.ToppingId3,
                ToppingId4 = pizzaOrder.ToppingId4,
                ToppingId5 = pizzaOrder.ToppingId5,
                Price = pizzaOrder.Price,
                Quantity = pizzaOrder.Quantity
            };
        }
    }
}