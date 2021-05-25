using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MVCFrontend.Controllers
{
    public class PizzaOrderController : Controller
    {
        Client client = new Client();
        // GET: PizzaOrderController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetByOrderId(int id)
        {
            var orders = client.GetAllPizzaOrders();
            var storeorders = orders.Where(o => o.OrderId == id);
            return View(storeorders);
        }

        // GET: PizzaOrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaOrderController/Create
        public ActionResult Create()
        {
            var pizzas = client.GetAllPizzas();
            ViewBag.Pizzas = new SelectList(pizzas, "Id", "Name", "Price");
            var sizes = client.GetAllSizes();
            ViewBag.Sizes = new SelectList(sizes, "Id", "Name", "Price");
            var crusts = client.GetAllCrusts();
            ViewBag.Crusts = new SelectList(crusts, "Id", "Name", "Price");
            var toppings = client.GetAllToppings();
            ViewBag.Toppings = new SelectList(toppings, "Id", "Name", "Price");
            var orders = client.GetAllOrders();
            var orderc = orders.Last<Order>();
            Deets.orderId = orderc.Id;
            return View();
        }

        // POST: PizzaOrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("OrderId", "PizzaId", "SizeId", "CrustId", "ToppingId1", "ToppingId2", "ToppingId3", "ToppingId4", "ToppingId5", "Price", "Quantity")]PizzaOrder order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    client.AddPizzaOrder(order);
                    return RedirectToAction("Index", "Order");
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

        // GET: PizzaOrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaOrderController/Edit/5
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

        // GET: PizzaOrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaOrderController/Delete/5
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
