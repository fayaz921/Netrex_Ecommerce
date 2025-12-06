using Application_Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.DTO_s.PaymentAndPayout
{
    public class AddPaymentDetailDto
    {
        public Guid OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double AmountPaid { get; set; }
    }
}
