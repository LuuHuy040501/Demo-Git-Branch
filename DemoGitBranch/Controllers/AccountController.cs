using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoGitBranch.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        //implement login logout function
        public void Login()
        {
            var huy = "login function implemented by Huy";
        }

        public void Resgiter()
        {
            var linh = "Register function implemented by Linh";
        }

        public void CheckOut()
        {
            var lung = "okoko";
        }
    }
}