using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Entities.PaymentAndPayoutModule
{
    public class Invoice
    {
        [Key]
        public Guid InvoiceId { get; set; }
        public Guid OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Total { get; set; }
    }
}
