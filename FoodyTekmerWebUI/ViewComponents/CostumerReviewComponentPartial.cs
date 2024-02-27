using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.ViewComponents
{
    public class CostumerReviewComponentPartial:ViewComponent
    {
        private readonly ICustomerReviewService _customerReviewService;

        public CostumerReviewComponentPartial(ICustomerReviewService customerReviewService)
        {
            _customerReviewService = customerReviewService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _customerReviewService.TGetAllList();
            return View(values);
        }
    }
}
