using Microsoft.AspNetCore.Mvc;
using WebUygulamaProje2.Models;
using WebUygulamaProje2.Utility;

namespace WebUygulamaProje2.Controllers
{
    public class KitapTuruController : Controller
    {
        //12.05.2025
        private readonly UygulamaDbContext _uygulamaDbContext; //=new uygulamaDB() konsolda nesne yapma mantığı gibi

        public KitapTuruController(UygulamaDbContext context) 
        {
            _uygulamaDbContext = context;
        }




        public IActionResult Index()
        {
            List<KitapTuru> objKitapTuruList = _uygulamaDbContext.KitapTurleri.ToList(); //veri tabanına gidip kitap türleri çek ve objKitapTuruList'esine alacak.
            return View(objKitapTuruList); //Liste işliyoruz parantez içine
            //return View(); ilk hali bu 12.05.2025
        }
    }
}
