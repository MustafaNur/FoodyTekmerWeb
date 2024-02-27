using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.Controllers
{
    public class DefaultController : Controller
    {
        /*
         
         */
        public IActionResult Index()
        {
            ViewBag.Title1 = "Ana Sayfa";
            ViewBag.Title2 = "Sayfalar";
            ViewBag.Title3 = "Ürünler";
            return View();
        }
        public IActionResult PartialHead()
        {
            return PartialView();
        }
        public IActionResult PartialNavbar()
        {
            return PartialView();
        }
        public IActionResult PartialHeader()
        {
            return PartialView();
        }
    }
}
