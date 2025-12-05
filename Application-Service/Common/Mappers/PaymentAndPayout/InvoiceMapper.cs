using Application_Service.DTO_s.PaymentAndPayout;
using Application_Service.Entities.PaymentAndPayoutModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Common.Mappers.PaymentAndPayout
{
    public static class InvoiceMapper
    {
        public static Invoice Map(this InvoiceDto dto)
        {
           return new Invoice
            {
                InvoiceId = Guid.NewGuid(),
                OrderId = dto.OrderId,
                Total = dto.Total,
                CreatedAt = DateTime.UtcNow
           };
        }
    }
}
