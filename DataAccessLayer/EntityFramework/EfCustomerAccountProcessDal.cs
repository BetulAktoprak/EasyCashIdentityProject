using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerAccountProcessDal : GenericRepository<CustomerAcccountProcess>, ICustomerAccountProcessDal
    {
        public List<CustomerAcccountProcess> MyLastProcess(int id)
        {
            using var context = new Context();
            var values = context.CustomerAcccountProcesses.Include(y => y.SenderCustomer).Include(w => w.ReceiverCustomer).ThenInclude(z => z.AppUser).Where(x => x.ReceiverID == id || x.SenderID == id).ToList();
            return values;
        }
    }
}
