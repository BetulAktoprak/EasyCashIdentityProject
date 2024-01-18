using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerAccountDal : GenericRepository<CustomerAcccount>, ICustomerAccountDal
    {
        public List<CustomerAcccount> GetCustomerAcccountsList(int id)
        {
            using var context = new Context();
            var values = context.CustomerAcccounts.Where(x => x.AppUserID ==  id).ToList();
            return values;
        }
    }
}
