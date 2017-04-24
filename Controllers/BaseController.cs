using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FreeVPN.Controllers
{
    public class BaseController : Controller
    {
        protected int uid = 0;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            //current user login . Acquire current user id 
            uid = Convert.ToInt32(HttpContext.Session.GetString("userid"));
            ViewBag.uid = uid;
        }
    }
}
