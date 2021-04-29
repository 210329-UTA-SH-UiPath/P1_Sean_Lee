using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  /// <summary>
  /// 
  /// </summary>
  public abstract class APizza : ACustomizable
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    //changed from Topping
    public APizza Pizza { get; set; }
    public List<Topping> Toppings { get; set; }

    protected APizza()
    {
      Factory();
      Pizza = this;
    }

    public decimal CalculateToppingPrice()
    {
      decimal toppingPrice = 0;
      foreach (var topping in Toppings)
      {
        toppingPrice += topping.Price;
      }
      return toppingPrice;
    }
    private void Factory()
    {
      Toppings = new List<Topping>();
      AddCrust();
      AddSize();
      AddToppings();
    }

    public decimal GetFinalPrice()
    {
      decimal price = Price + Crust.Price + Size.Price;

      foreach (var topping in Toppings)
      {
        price += topping.Price;
      }
      return price;
    }

    public virtual void AddSize()
    {
      Size = new Size();
    }
    public virtual void AddCrust()
    {
      Crust = new Crust();
    }
    // public abstract void AddToppings();
    public virtual void AddToppings()
    {
      Toppings = new List<Topping>();
    }

    public override string ToString()
    {
      return $"{Name} - {Price}";
    }

  }
}
