using Application_Service.DTO_s.PaymentAndPayout;
using Application_Service.Entities.PaymentAndPayoutModule;
using Application_Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Common.Mappers.PaymentAndPayout
{
    public static class AddPaymentMapper
    {
        public static PaymentDetail Map(this AddPaymentDetailDto dto)
        {
            return new PaymentDetail
            {
                PaymentDetailId = Guid.NewGuid(),
                OrderId = dto.OrderId,
                PaymentMethod = dto.PaymentMethod,
                AmountPaid = dto.AmountPaid,
                PaymentStatus = PaymentStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
