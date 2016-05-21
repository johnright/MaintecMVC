using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Common
{
    public class User : Person
    {
        public string Password { get; set; }  //possibile uso FB user quindi inutile
        public double Gain { get; set; }
        public double Sales { get; set; }
        public bool IsActive { get; set; }
        public UserType UserType { get; set; }
       
    }


    public enum UserType
    {
        Administrator,
        Seller,
        Engraver
    }
}
