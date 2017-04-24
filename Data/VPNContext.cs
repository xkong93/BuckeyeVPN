using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VPN.Models;

namespace VPN.Data
{
    public class VPNContext : DbContext
    {
        public VPNContext(DbContextOptions<VPNContext> options) : base(options)
        {
        }

        public DbSet<FV_user> fv_user { get; set; }
        public DbSet<FV_order> fv_order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FV_user>().ToTable("FV_user");
            modelBuilder.Entity<FV_order>().ToTable("FV_order");
        }
    }

}
