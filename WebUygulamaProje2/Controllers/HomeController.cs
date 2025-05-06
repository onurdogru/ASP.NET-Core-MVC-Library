using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebUygulamaProje2.Models;

namespace WebUygulamaProje2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //View/Home klas�r�ndeki index.cshtml ifade eder.
        {
            return View(); //Burada parantez i�ine "" i�inde ne yazarsan, Views i�indeki o html sayfas� gelir.
                           //Yani ilk a��lan sayfay�da buraya "" i�inde yazarak belirleyebiliriz.
        }

        public IActionResult Privacy()
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
