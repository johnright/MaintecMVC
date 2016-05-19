using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintecLaser.Common
{
    public class Order : Entity
    {
        public Customer Customer { get; set; } //Made to
        public User User { get; set; }   //Made from
        public List<OrderDetail> OrderDetails { get; set; }
        public int Pieces { get; set; }
        public double Discount { get; set; }
        public string ShippingCode { get; set; }
        public DateTime CreateDate { get; set; }
        #region ReadOnly
        public double FinalPrice { get { return this.OrderDetails.Sum(x=>x.Total) - this.Discount; } }  //in caso di sconto sull'intero ordine
        #endregion
    }
        public enum OrderState
    {
        Pending,     //in attesa approvazione
        Charge,      // preso in carico
        Processing,  //in Lavorazione
        Complete,    //Completo
        Shipped      //Spedito

    }
}
