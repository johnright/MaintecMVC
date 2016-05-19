using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Common
{
   public class Product:Entity
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public object Picture { get; set; }
        public bool IsAvaiable { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

    }
}
