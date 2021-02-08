using MVC_SanatBlog.Models.Context;
using MVC_SanatBlog.Models.Entities;
using MVC_SanatBlog.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_SanatBlog.Controllers
{
    public class HomeController : Controller

    {
        girisContext db = new girisContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gorsel()
        {
            

            return View();
        }

        public ActionResult Performans()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = db.AppUsers.Where(x => x.UserName == loginVM.UserName && x.Password == loginVM.Password).FirstOrDefault();
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, true);
                }
            }
            return RedirectToAction("Index");
        }
    }
}