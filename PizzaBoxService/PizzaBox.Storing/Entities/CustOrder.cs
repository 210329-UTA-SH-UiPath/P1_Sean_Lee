using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class CustOrder
    {
        public CustOrder()
        {
            PizzaOrders = new HashSet<PizzaOrder>();
        }

        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }

        public virtual Cust Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<PizzaOrder> PizzaOrders { get; set; }
    }
}
