using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.Controllers
{
    public class VisitOurController : Controller
    {
        private readonly IVisitOurService _visitOurService;

        public VisitOurController(IVisitOurService visitOurService)
        {
            _visitOurService = visitOurService;
        }

        public IActionResult Index()
        {
            var values = _visitOurService.TGetAllList();
            return View(values);
        }
    }
}
