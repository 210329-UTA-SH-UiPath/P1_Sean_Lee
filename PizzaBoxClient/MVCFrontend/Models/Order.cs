using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontend.Models
{
    public class Order
    {
        private DateTime now = DateTime.Now;
        public int Id { get; set; }
        public DateTime PurchaseDate
        {
            get { return now; }
            set
            {
                now.ToString("yyyy - MM - dd HH: mm:ss.fff");
            }
        }
        //public string PurchaseDate { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public decimal Price { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public List<Customer> Customers { get; set; }

        //public Order()
        //{
        //    PurchaseDate = now.ToString("yyyy-MM- dd HH: mm:ss.fff");
        //}
        //DateTime now = DateTime.Now;
        //[Key]
        //[Display(AutoGenerateField = false)]
        //public int Id { get; set; }
        //[Display(AutoGenerateField = false)]
        //public DateTime PurchaseDate
        //{
        //    get { return now; }
        //    set
        //    {
        //        PurchaseDate = now;
        //    }
        //}
        //public decimal Price { get; set; }
        //public int CustomerId { get; set; }
        //public int StoreId { get; set; }

        //public virtual Customer Customer { get; set; }
        //public virtual Store Store { get; set; }
    }
}
