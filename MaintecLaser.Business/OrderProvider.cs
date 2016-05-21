using MaintecLaser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Business
{
    public class OrderProvider : BaseProvider, IService<Order>
    {
        //private static StoreManagerModel DbContext = new StoreManagerModel();


       

        public void Delete(Order item)
        {
            DbContext.Orders.Remove(item);

            SaveChanges(true);
        }

        public IList<Order> GetAll()
        {
            return DbContext.Orders.ToList();
        }

        public IList<Order> GetAll(int nPages)
        {
            throw new NotImplementedException();
        }

        public Order GetEntity(string id)
        {
            Order result = DbContext.Orders.Where(x => x.ID.Equals(id)).FirstOrDefault();
            this.SaveChanges();
            return result;
        }

        public void Insert(Order item)
        {
            DbContext.Orders.Add(item);
            SaveChanges(true);
        }

        public void Update(Order item)
        {
            var upd = this.GetEntity(item.ID);
            upd = item;
            SaveChanges(true);
        }


        public IList<Order> GetOrders(User user)
        {
            return this.GetAll().Where(x => x.User.ID.Equals(user.ID)).ToList();
        }
    }
}
