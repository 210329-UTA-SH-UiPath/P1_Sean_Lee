using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class Cust
    {
        public Cust()
        {
            CustOrders = new HashSet<CustOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public virtual ICollection<CustOrder> CustOrders { get; set; }
    }
}
