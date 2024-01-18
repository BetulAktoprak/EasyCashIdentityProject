using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GQ3I6OJ;initial catalog=EasyCashDb;User ID=sa;Password=1;");
        }

        public DbSet<CustomerAcccount> CustomerAcccounts { get; set; }
        public DbSet<CustomerAcccountProcess> CustomerAcccountProcesses { get; set; }
        public DbSet<ElectricBill> ElectricBills { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerAcccountProcess>()
                .HasOne(x => x.SenderCustomer)
                .WithMany(y => y.CustomerSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<CustomerAcccountProcess>()
                .HasOne(x => x.ReceiverCustomer)
                .WithMany(y => y.CustomerReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(builder);
        }
    }
}
