using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.ViewComponents
{
    public class VisitOurComponentPartial:ViewComponent
    {
        private readonly IVisitOurService _visitOurService;

        public VisitOurComponentPartial(IVisitOurService visitOurService)
        {
            _visitOurService = visitOurService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _visitOurService.TGetAllList();
            return View(values);
        }
    }
}
