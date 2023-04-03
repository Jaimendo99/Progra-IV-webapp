using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webApp1.Models;

namespace webApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

        public IActionResult Client()
        {

            var clientList = new List<Cliente>();
            clientList.Add(new Cliente("Jaime", "1312242900","jaimendo@gmail.com",23));
            clientList.Add(new Cliente("Hola", "1312242920", "jaimendo@gmail.com", 23));
            clientList.Add(new Cliente("Chaop", "1312242930", "jaimendo@gmail.com", 23));
            clientList.Add(new Cliente("Manana", "1312242940", "jaimendo@gmail.com", 23));
            clientList.Add(new Cliente("A veces", "1312242950", "jaimendo@gmail.com", 23));
            return View(clientList);
        }

        public IActionResult Inventory()
        {
            return View();
        }

        public IActionResult Config()
        {
            return View();
        }

  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}