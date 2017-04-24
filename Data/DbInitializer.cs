using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VPN.Models;

namespace VPN.Data
{
    public class DbInitializer
    {
        public static void Initialize(VPNContext context)
        {
            context.Database.EnsureCreated();
            if (context.fv_user.Any())
            {
                return;
            }
            if (context.fv_order.Any())
            {
                return;
            }
        }
    }
}
