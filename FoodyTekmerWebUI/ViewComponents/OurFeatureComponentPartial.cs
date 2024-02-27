using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.ViewComponents
{
    public class OurFeatureComponentPartial:ViewComponent
    {
        private readonly IOurFeatureService _ourFeatureService;

        public OurFeatureComponentPartial(IOurFeatureService ourFeatureService)
        {
            _ourFeatureService = ourFeatureService;
        }

        public IViewComponentResult Invoke()
        {
            List<FoodyTekmerEntityLayer.Concrete.OurFeature> features = _ourFeatureService.TGetAllList();
            return View(features);
        }
    }
}
