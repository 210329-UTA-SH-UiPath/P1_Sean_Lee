using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class Store
    {
        public Store()
        {
            CustOrders = new HashSet<CustOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustOrder> CustOrders { get; set; }
    }
}
