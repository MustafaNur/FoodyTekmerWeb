using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerDataAccessLayer.Abstract;
using FoodyTekmerEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerBusinessLayer.Concrete
{
    public class BlogManager:IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TAdd(Blog entity)
        {
            throw new NotImplementedException();
        }
        public List<Blog> GetLast3Blog()
        {
            var tumListe = _blogDal.GetAllList();
            var sonUcOge = tumListe.Skip(Math.Max(0, tumListe.Count() - 3)).ToList();
            return sonUcOge;
        }
        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetAllList()
        {
            return _blogDal.GetAllList();
        }

        public Blog TGetById(int id)
        {
            throw new NotImplementedException();
        }
        public List<Blog> GetBlogID(int id)
        {
            throw new NotImplementedException();
        }
        public void TUpdate(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
