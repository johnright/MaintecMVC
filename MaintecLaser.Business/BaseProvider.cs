using MaintecLaser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Business
{
    public class BaseProvider
    {
        StoreManagerModel _dbContext;
        protected StoreManagerModel DbContext
        {
            get
            {
                if (_dbContext == null)
                    _dbContext = new StoreManagerModel();
                return _dbContext;
            }



            set { _dbContext = value; }
        }

        public void SaveChanges(bool isDML = false)
        {
            if (isDML)
                this.DbContext.SaveChanges();

            this.DbContext.Dispose();
            this.DbContext = null;

        }
    }
}
