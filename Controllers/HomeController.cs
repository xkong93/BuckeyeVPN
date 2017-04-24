using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VPN.Models;
using VPN.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace FreeVPN.Controllers
{
    public class HomeController : BaseController
    {
        private readonly VPNContext _context;

        public HomeController(VPNContext context)
        {
            _context = context;
        }



        //main page/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Wintuto()
        {
            return View();
        }
        public IActionResult Mactuto()
        {
            return View();
        }
    }
}
