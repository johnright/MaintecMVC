using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Common
{
    public class Address:Entity
    {
        public StreetType StreetType { get; set; }
        public string StreetName { get; set; }
        public City City { get; set; }
        public int Cap { get; set; }
        public string Civico { get; set; }
    }


    public class StreetType:Entity
    {
        public static string Via = "Via",
         Corso="Corso",
         Piazza="Piazza",
         Viale="Viale",
         Traversa="Traversa";

    }
}
