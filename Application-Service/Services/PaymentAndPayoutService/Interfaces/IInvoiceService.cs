using Application_Service.DTO_s.PaymentAndPayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.PaymentAndPayoutService.Interfaces
{
    public interface IInvoiceService
    {
        Task CreateInvoiceAsync(InvoiceDto invoiceDto);
    }
}
