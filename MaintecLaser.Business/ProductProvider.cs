using MaintecLaser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Business
{
    public class ProductProvider : BaseProvider, IService<Product>
    {
        public void Delete(Product item)
        {
            this.DbContext.Products.Remove(item);
            this.SaveChanges(true);
        }

        public IList<Product> GetAll()
        {
            var _result = this.DbContext.Products.ToList();
            SaveChanges();
            return _result;
        }

        public IList<Product> GetAll(int nPages)
        {
            throw new NotImplementedException();
        }

        public Product GetEntity(string id)
        {
            var _result = GetAll().Where(x => x.ID.Equals(id)).FirstOrDefault();
            SaveChanges();
            return _result;

        }

        public void Insert(Product item)
        {
            this.DbContext.Products.Add(item);
            SaveChanges(true);
        }

        public void Update(Product item)
        {
            var _toUp = this.DbContext.Products.Where(x => x.ID == item.ID).FirstOrDefault();
            _toUp = item;
            SaveChanges(true);
        }
    }
}
