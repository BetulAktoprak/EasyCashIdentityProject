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
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAcccountProcess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustomerAcccountProcess? TGetByID(int id)
        {
            return _customerAccountProcessDal.GetByID(id);
        }

        public List<CustomerAcccountProcess> TGetList()
        {
            return _customerAccountProcessDal.GetList();
        }

        public void TInsert(CustomerAcccountProcess t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public List<CustomerAcccountProcess> TMyLastProcess(int id)
        {
            return _customerAccountProcessDal.MyLastProcess(id);
        }

        public void TUpdate(CustomerAcccountProcess t)
        {
            _customerAccountProcessDal.Update(t);
        }



        
    }
}
