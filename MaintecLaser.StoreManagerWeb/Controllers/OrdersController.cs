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
            //List<Person> p =
            return View(new UserProvider().GetAll());
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            UserProvider provider = new UserProvider();
            provider.Insert(user);

            return Index();

        }


    }
}