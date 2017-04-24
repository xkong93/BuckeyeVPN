using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using VPN.Data;
using VPN.Models;

namespace FreeVPN.Controllers
{
    public class OrderController : BaseController
    {
        private readonly VPNContext _context; 
        public OrderController(VPNContext context)
        {
            _context = context;
        }
        /// OrderDetail
     
        public IActionResult OrderDetail(int id)
        {
            //use id to get user model 
            FV_order usermodel = _context.fv_order.SingleOrDefault(m => m.id == id);
            return View(usermodel);
        }


        //Order list---my oyders 
        public IActionResult OrderList()
        {
            //get user id
            int uid = Convert.ToInt32(HttpContext.Session.GetString("userid"));
            //if user id less than 0, be directed to login page 
            if (uid <= 0)
            {
                return RedirectToAction("Login", "User");
            }
            //get user's order list ... EF checks all user's order list 
            FV_order[] fvords = _context.fv_order.Where(m => m.userid == uid).ToArray();

            return View(fvords);
        }


        
        /// show order success 
        public IActionResult OrderSuc(int id)
        {
            //get detail by using EF 
            FV_order usermodel = _context.fv_order.SingleOrDefault(m => m.id == id);

            return View(usermodel);
        }

       //Select orders 
        public IActionResult SetOrder()
        {
            //Check current user id
            int uid = Convert.ToInt32(HttpContext.Session.GetString("userid"));
            //check whether user signs in 
            if (uid <= 0)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        //place order 
        [HttpPost]
        public string Buy(int type)
        {
            //Check current user id
            int uid = Convert.ToInt32(HttpContext.Session.GetString("userid"));
            //check whether user signs in 
            if (uid <= 0)
            {
                return "you are not login.";
            }
            //give an random VPN account 
            string vpnname = "FreeVPN_" + new Random().Next(100, 999);
            // to a form 
            FV_order fvorder = _context.fv_order.Add(new FV_order { userid = uid, buy_type = type, createtime = DateTime.Now, VPNname = vpnname, VPNpwd = vpnname, status = 1 }).Entity;
            //call fvorder in Model 
            if (_context.SaveChanges() > 0)
            {
                return fvorder.id.ToString();
            }

            return "";
        }

    }
}
