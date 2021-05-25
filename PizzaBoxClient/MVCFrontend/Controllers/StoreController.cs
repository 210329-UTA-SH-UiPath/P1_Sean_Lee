using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontend.Controllers
{
    public class StoreController : Controller
    {
        Client client = new Client();
        public IActionResult Index()
        {
            var stores = client.GetAllStores();
            return View(stores);
        }

    }
}
