using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Common
{
    public class OrderDetail : Entity
    {
        public Product Product { get; set; }
        public int Pieces { get; set; }

        public double Total { get { return Product.Price * Pieces; } }

    }
}
