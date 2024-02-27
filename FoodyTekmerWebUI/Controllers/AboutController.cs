using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerDataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetAllList();
            return View(values);
        }
    }
}
