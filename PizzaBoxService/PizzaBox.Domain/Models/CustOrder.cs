using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class CustOrder
  {
    public int Id { get; set; }
    public DateTime PurchaseDate { get; set; }
    public decimal Price { get; set; }
    public int CustomerId { get; set; }
    public int StoreId { get; set; }

    //public virtual Cust Cust { get; set; }
    //public virtual Store Store { get; set; }

    //public CustOrder()
    //{
    //  PurchaseDate = DateTime.Now;
    //}
    /// <summary>
    /// 
    /// </summary>
    public void Save()
    {
      // if (_fileRepository.WriteToFile(Items, "orders.xml"))
      // System.Console.WriteLine("Thanks, added to order!");
    }
  }
}
