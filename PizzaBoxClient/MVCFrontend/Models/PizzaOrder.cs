using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontend.Models
{
    public class PizzaOrder
    {
        public int OrderId { get; set; }
        [Required]
        public int PizzaId { get; set; }
        [Required]
        public int SizeId { get; set; }
        [Required]
        public int CrustId { get; set; }
        public int? ToppingId1 { get; set; }
        public int? ToppingId2 { get; set; }
        public int? ToppingId3 { get; set; }
        public int? ToppingId4 { get; set; }
        public int? ToppingId5 { get; set; }
        //public decimal Price { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]+")]
        [Range(1, 50, ErrorMessage ="Quantity must be 1 to 50")]
        public byte Quantity { get; set; }
        public Pizza Pizza { get; set; }
        public Topping Topping { get; set; }
        public Crust Crust { get; set; }
        public Size Size { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<Topping> Toppings { get; set; }

        //public decimal CalculateToppingPrice()
        //{
        //    decimal toppingPrice = 0;
        //    foreach (var topping in Toppings)
        //    {
        //        toppingPrice += topping.Price;
        //    }
        //    return toppingPrice;
        //}

        public decimal GetFinalPrice()
        {
            decimal price = Pizza.Price + Crust.Price + Size.Price;

            foreach (var topping in Toppings)
            {
                price += topping.Price;
            }
            return price;
        }
    }
}
