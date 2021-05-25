using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontend.Controllers
{
    public class CustomerController : Controller
    {
        Client client = new Client();
        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = client.GetAllCustomers();
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var orders = client.GetAllOrders();
            var custorders = orders.Where(o => o.CustomerId == id);
            return View(custorders);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name", "Password")] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    client.AddCustomer(customer);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(customer);
                }
            }
            catch
            {
                return View();
            }
        }
        //public ViewResult GetCustomerById(int id)
        //{
        //    //var customer = client.GetCustomerById(id);
        //    //return View("GetCustomerById", customer);
        //}

        // Not working
        [HttpPost]
        public JsonResult DoesNameExist(string name)
        {
            return Json(IsUserAvailable(name));
        }
        // Not Working
        public bool IsUserAvailable(string name)
        { 
            IEnumerable<Customer> RegisterUsers = client.GetAllCustomers();

            var usersid = (from u in RegisterUsers
                              where u.Name == name
                              select new { name }).FirstOrDefault();

            bool status;
            if (usersid != null)
            {
                status = false;
            }
            else
            {
                status = true;
            }


            return status;
        }

    }
}
