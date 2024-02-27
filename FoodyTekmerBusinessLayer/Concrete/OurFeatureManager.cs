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
    public class OurFeatureManager:IOurFeatureService
    {
        private readonly IOurFeatureDal _ourFeatureDal;

        public OurFeatureManager(IOurFeatureDal ourFeatureDal)
        {
            _ourFeatureDal = ourFeatureDal;
        }

        public void TAdd(OurFeature entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OurFeature> TGetAllList()
        {
            return _ourFeatureDal.GetAllList();
        }

        public OurFeature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OurFeature entity)
        {
            throw new NotImplementedException();
        }
    }
}
