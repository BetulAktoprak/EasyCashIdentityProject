using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(CustomerAcccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public CustomerAcccount? TGetByID(int id)
        {
            return _customerAccountDal.GetByID(id);
        }

        public List<CustomerAcccount> TGetCustomerAcccountsList(int id)
        {
            return _customerAccountDal.GetCustomerAcccountsList(id);
        }

        public List<CustomerAcccount> TGetList()
        {
            return _customerAccountDal.GetList();
        }

        public void TInsert(CustomerAcccount t)
        {
            _customerAccountDal.Insert(t);
        }

        public void TUpdate(CustomerAcccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
