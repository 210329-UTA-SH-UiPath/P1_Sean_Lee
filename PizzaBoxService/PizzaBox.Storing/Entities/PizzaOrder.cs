using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaBox.Storing.Entities
{
    public partial class PizzaOrder
    {
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        public int SizeId { get; set; }
        public int CrustId { get; set; }
        public int? ToppingId1 { get; set; }
        public int? ToppingId2 { get; set; }
        public int? ToppingId3 { get; set; }
        public int? ToppingId4 { get; set; }
        public int? ToppingId5 { get; set; }
        public decimal Price { get; set; }
        public byte Quantity { get; set; }

        public virtual CustOrder Order { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}
