using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Business
{
   
    interface IService<T>
    {
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        IList<T> GetAll();
        IList<T> GetAll(int nPages);
        T GetEntity(string id);
    }
}
