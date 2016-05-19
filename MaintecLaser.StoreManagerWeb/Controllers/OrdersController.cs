using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaintecLaser.Business;
using MaintecLaser.Common;
namespace MaintecLaser.StoreManagerWeb.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            List<Person> p = new List<Person>();
            p.Add(new Person() {Name="Giacomo",Surname="Uncino",Email="giacomo.uncino@gmail.com" });
            return View(p);
        }
    }
}