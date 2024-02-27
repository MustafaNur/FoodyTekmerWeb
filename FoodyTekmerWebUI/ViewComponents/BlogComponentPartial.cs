using FoodyTekmerBusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.ViewComponents
{
    public class BlogComponentPartial:ViewComponent
    {
        private readonly IBlogService _blogService;

        public BlogComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var value = _blogService.TGetAllList();
            return View(value);
        }
    }
}
