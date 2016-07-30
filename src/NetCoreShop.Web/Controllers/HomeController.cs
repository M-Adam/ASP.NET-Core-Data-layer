using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreShop.Service;

namespace NetCoreShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceTest _serviceTest;

        public HomeController(IServiceTest serviceTest)
        {
            this._serviceTest = serviceTest;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


#region Testing
        public string ServiceTest()
        {
            return _serviceTest.Test();
        }

        public string ContextTest()
        {
            var m = _serviceTest.ContextTest();

            return $"Ajdik to: {m.Id}";
        }
#endregion 
    }
}
