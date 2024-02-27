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
    public class CostumerReviewManager:ICustomerReviewService
    {
        private readonly ICustomerReviewDal _customerReviewDal;

        public CostumerReviewManager(ICustomerReviewDal customerReviewDal)
        {
            _customerReviewDal = customerReviewDal;
        }

        public void TAdd(CustomerReview entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerReview> TGetAllList()
        {
            return _customerReviewDal.GetAllList();
        }

        public CustomerReview TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CustomerReview entity)
        {
            throw new NotImplementedException();
        }
    }
}
