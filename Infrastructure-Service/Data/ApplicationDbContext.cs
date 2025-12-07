using Application_Service.Entities.PaymentAndPayoutModule;
using Application_Service.Entities.UserModule;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
      public DbSet<User> Users { get; set; }

       public DbSet<Invoice> Invoices { get; set; }
    }
    
}
