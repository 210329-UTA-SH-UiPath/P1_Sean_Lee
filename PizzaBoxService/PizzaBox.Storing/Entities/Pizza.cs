using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaOrders = new HashSet<PizzaOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<PizzaOrder> PizzaOrders { get; set; }
    }
}
