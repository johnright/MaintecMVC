using MaintecLaser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Business
{
    public class OrderProvider : IService<Order>
    {
        public void Delete(Order item)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAll(int nPages)
        {
            throw new NotImplementedException();
        }

        public Order GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Order item)
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }


        public IList<Order> GetOrders(User user)
        {
            return this.GetAll().Where(x => x.User.ID.Equals(user.ID)).ToList();
        }
    }
}
