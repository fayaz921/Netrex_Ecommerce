using Application_Service.Common.Mappers.PaymentAndPayout;
using Application_Service.DTO_s.PaymentAndPayout;
using Application_Service.Services.Interfaces;
using Domain_Service.RepoInterfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.Implementation
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateInvoiceAsync(InvoiceDto invoiceDto)
        {
            var invoice = invoiceDto.Map();
            await _unitOfWork.Invoices.Create(invoice);
        }
    }
}
