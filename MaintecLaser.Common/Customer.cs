using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Common
{
    public class Customer : Person
    {

        public string Piva { get; set; }
        public string BankAccount { get; set; }
        public string WebSite { get; set; }
        public string Note { get; set; }
        public Address Address { get; set; }

    }
}
