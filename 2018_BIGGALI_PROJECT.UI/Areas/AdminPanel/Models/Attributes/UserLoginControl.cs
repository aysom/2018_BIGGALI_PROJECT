using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2018_BIGGALI_PROJECT.UI.Areas.AdminPanel.Models.Attributes
{
    public class UserLoginControl : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                filterContext.HttpContext.Response.Redirect("/AdminPanel/AdminLogin/Index");
            }
        }
    }
}