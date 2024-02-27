using FoodyTekmerBusinessLayer.Concrete;
using FoodyTekmerDataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.ViewComponents
{
    public class BlogLast3PostComponentPartial:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3Blog();
            return View(values);
        }
    }
}
