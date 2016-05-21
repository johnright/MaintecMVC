using MaintecLaser.Business;
using MaintecLaser.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintecLaser.StoreManagerWeb.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {

            return View(new MaintecLaser.Business.UserProvider().GetAll().FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            UserProvider prv = new UserProvider();
            prv.Insert(user);
            return Index();
        }

        [HttpGet]
        public ActionResult GetUserList()
        {
            UserProvider prv = new UserProvider();
            var list = prv.GetAll().ToList(); ;


            return PartialView("_UserList",list);
        }

        // public ActionResult 
    }
}