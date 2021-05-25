using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCFrontend.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MVCFrontend.Controllers
{
    public class OrderController : Controller
    {
        Client client = new Client();

        public ActionResult GetByCustomerId(int id)
        {
            var orders = client.GetAllOrders();
            var custorders = orders.Where(o => o.CustomerId == id);
            return View(custorders);
        }
        [HttpGet]
        //public IEnumerable<Customer> GetCustomers()
        //{
        //    var customers = client.GetAllCustomers();
        //    //ViewBag.Customers = new SelectList(customers, "Id", "Name", "Password");
        //    ViewBag.Customers = customers;
        //    return customers;
        //}

        public ActionResult GetByStoreId(int id)
        {
            var orders = client.GetAllOrders();
            var storeorders = orders.Where(o => o.StoreId == id);
            return View(storeorders);
        }
        // GET: OrderController
        public ActionResult Index()
        {
            if (Deets.customerId != 0)
            {
                var corders = client.GetAllOrders();
                var storeorders = corders.Where(o => o.CustomerId == Deets.customerId);
                return View(storeorders);
            }
            var orders = client.GetAllOrders();
            return View(orders);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int oid, int cid)
        {
            var orders = client.GetPizzaOrderByCustomerOrder(oid, cid);
            return View("Details", orders);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            var customers = client.GetAllCustomers();
            ViewBag.Customers = new SelectList(customers, "Id", "Name", "Password");
            var stores = client.GetAllStores();
            ViewBag.Stores = new SelectList(stores, "Id", "Name");
            //trying here
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("PurchaseDate", "Price", "CustomerId", "StoreId")]Order order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    client.AddOrder(order);
                    Deets.customerId = order.CustomerId;
                    Deets.storeId = order.StoreId;
                    return RedirectToAction("Create", "PizzaOrder");
                }
                else
                {
                    return View(order);
                }
            }
            catch
            {
                return View();
            }
        }

        private void GetOrderId()
        {

        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
