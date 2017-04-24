using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VPN.Models;
using Microsoft.AspNetCore.Http;
using VPN.Data;


namespace FreeVPN.Controllers
{
    public class UserController : BaseController
    {
        private readonly VPNContext _context;

        public UserController(VPNContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Reg()
        {
            return View();
        }
            

        //log out
        public IActionResult Logout()
        {
            //clear the session 
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }


       
        //log in 
        [HttpPost]
        public string LoginDo(string email, string pwd)
        {
            //check acct and pwd 
            FV_user usermodel = _context.fv_user.SingleOrDefault(m => m.email == email && m.pwd == pwd);
            if (usermodel == null)
            {
                return "email or password is error.";
            }
            //save session key
            HttpContext.Session.SetString("userid", usermodel.id.ToString());
            return "1";
        }


        //Register
        [HttpPost]
        public string RegDo(string email, string pwd)
        {
            //check whether the account has been registered 
            FV_user usermodel = _context.fv_user.SingleOrDefault(m => m.email == email && m.pwd == pwd);
            if (usermodel != null)
            {
                return "the email was registered.";
            }
            //use EF to insert acct and pwd to DB 
            usermodel = _context.fv_user.Add(new FV_user { email = email, pwd = pwd, name = "" }).Entity;

            //submit
            if (_context.SaveChanges() > 0)
            {
                //save session 
                HttpContext.Session.SetString("userid", usermodel.id.ToString());
                return "1";
            }
            return "";
        }
    }
}
