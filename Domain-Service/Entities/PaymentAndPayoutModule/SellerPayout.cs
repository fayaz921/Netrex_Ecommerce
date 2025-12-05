using Application_Service.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Entities.PaymentAndPayoutModule
{
    public class SellerPayout
    {
        [Key]
        public Guid SellerPayoutId { get; set; }
        public Guid SellerId { get; set; }
        public Guid OrderId { get; set; }
        public double AmountToPay { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime PayOutDate { get; set; }
    }
}
