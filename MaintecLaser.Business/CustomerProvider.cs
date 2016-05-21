using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaintecLaser.Common;
namespace MaintecLaser.Business
{
    public class CustomerProvider : BaseProvider, IService<Customer>
    {

        public void Delete(Customer item)
        {
            this.DbContext.Customers.Remove(item);
            this.SaveChanges(true);
        }

        public IList<Customer> GetAll()
        {
            var _result = this.DbContext.Customers.ToList();
            SaveChanges();
            return _result;
        }

        public IList<Customer> GetAll(int nPages)
        {
            throw new NotImplementedException();
        }

        public Customer GetEntity(string id)
        {
            var _result = this.DbContext.Customers.Where(x => x.ID == id).FirstOrDefault();
            SaveChanges();
            return _result;
        }

        public void Insert(Customer item)
        {
            this.DbContext.Customers.Add(item);
            SaveChanges(true);
        }

        public void Update(Customer item)
        {
            var _toUp = this.DbContext.Customers.Where(x => x.ID == item.ID).FirstOrDefault();
            _toUp = item;
            SaveChanges(true);
        }
    }
}
