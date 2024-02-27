using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.Controllers
{
    public class OurFeatureController : Controller
    {
        private readonly IOurFeatureService _ourFeatureService;

        public OurFeatureController(IOurFeatureService ourFeatureService)
        {
            _ourFeatureService = ourFeatureService;
        }

        public IActionResult Index()
        {
            var values  = _ourFeatureService.TGetAllList();
            return View(values);
        }
    }
}
