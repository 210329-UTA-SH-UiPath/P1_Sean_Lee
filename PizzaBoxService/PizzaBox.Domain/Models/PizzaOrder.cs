using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace PizzaBox.Domain.Models
{
  public class PizzaOrder
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
  }
}
