using MaintecLaser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Business
{
    public class UserProvider : BaseProvider, IService<User>
    {

        public UserProvider()
        {



        }

        public void Delete(User item)
        {
            this.DbContext.Users.Remove(item);
            SaveChanges(true);

        }

        public IList<User> GetAll()
        {
            using (DbContext)
            {
                return DbContext.Users.ToList();
            }

        }

        public IList<User> GetAll(int nPages)
        {
            using (DbContext)
            {
                return DbContext.Users.ToList().Take(nPages).ToList();
            }
        }

        public User GetEntity(string id)
        {
            using (DbContext)
            {
                return DbContext.Users.ToList().Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public void Insert(User item)
        {
            using (DbContext)
            {
                item.ID = Guid.NewGuid().ToString();
                DbContext.Users.Add(item);
                DbContext.SaveChanges();
            }

        }

        public void Update(User item)
        {
            using (DbContext)
            {

                var _toUp = DbContext.Users.ToList().Where(x => x.ID == item.ID).FirstOrDefault();
                _toUp = item;
                DbContext.SaveChanges();
            }
        }

        public User GetUserDetails(string userId)
        {
            return this.GetAll().Where(x => x.ID == userId).FirstOrDefault();

        }
    }
}
