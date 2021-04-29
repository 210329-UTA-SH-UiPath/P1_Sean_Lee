using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Store
  {
    //public Store()
    //{
    //  CustOrders = new HashSet<CustOrder>();
    //}
    public int Id { get; set; }
    public string Name { get; set; }
    //public virtual ICollection<CustOrder> CustOrders { get; set; }

  }
}