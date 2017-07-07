using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureKeyVault.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AzureKeyVault.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppConfiguration _appConfiguration;
        public HomeController(IOptionsSnapshot<AppConfiguration> appConfiguration)
        {
            _appConfiguration = appConfiguration.Value;
        }

        public IActionResult Index()
        {
            ViewData["ConnectionString"] = _appConfiguration.ConnectionStrings.HumanKode;
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
    }
}
