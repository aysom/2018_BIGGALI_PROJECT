using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2018_BIGGALI_PROJECT.UI.Areas.AdminPanel.Controllers
{
    public class AdminHomeController : BaseController
    {
        // GET: AdminPanel/AdminHome
        public ActionResult Index()
        {
            return View();
        }
    }
}