using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThpK22CNT3Lession10.Models;

namespace ThpK22CNT3Lession10.Controllers
{
    public class ThpHomeController : Controller
    {
        public ActionResult ThpIndex()
        {
            //Check data from sesstion
            if (Session["ThpAccount"] !=null)
            {
                var thpAccount = Session["ThpAccount"] as ThpAccount;
                ViewBag.FullName= thpAccount.ThpFullName;
            }
            return View();
        }

        public ActionResult ThpAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ThpContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}