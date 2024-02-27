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
    public class VisitOurManager : IVisitOurService
    {
        private readonly IVisitOurDal _visitOurDal;

        public VisitOurManager(IVisitOurDal visitOurDal)
        {
            _visitOurDal = visitOurDal;
        }

        public void TAdd(VisitOurFirm entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<VisitOurFirm> TGetAllList()
        {
            return _visitOurDal.GetAllList();
        }

        public VisitOurFirm TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(VisitOurFirm entity)
        {
            throw new NotImplementedException();
        }
    }
}
