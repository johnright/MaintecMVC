using MaintecLaser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Business
{
    public class UserProvider : IService<User>
    {
        public  StoreManagerModel DbContext;


        public UserProvider()
        {

           

        }

        public void Delete(User item)
        {


        }

        public IList<User> GetAll()
        {
            using (DbContext = new StoreManagerModel())
            {
                return DbContext.Users.ToList();
            }

        }

        public IList<User> GetAll(int nPages)
        {
            throw new NotImplementedException();
        }

        public User GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User item)
        {
            using (DbContext = new StoreManagerModel())
            {
                item.ID = Guid.NewGuid().ToString();
                DbContext.Users.Add(item);
                DbContext.SaveChanges();
            }
            
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }

        public User GetUserDetails(string userId)
        {
            return this.GetAll().Where(x => x.ID == userId).FirstOrDefault();

        }
    }
}
