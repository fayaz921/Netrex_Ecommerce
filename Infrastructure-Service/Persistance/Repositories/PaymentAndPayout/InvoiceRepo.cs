using Application_Service.Entities.PaymentAndPayoutModule;
using Application_Service.RepoInterfaces.PaymentAndPayout;
using Infrastructure_Service.Data;

namespace Application_Service.Persistance.Repositories.PaymentAndPayout
{
    public class InvoiceRepo : IInvoiceRepo
    {
        private readonly ApplicationDbContext _context;
        public InvoiceRepo(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public async Task CreateInvoice(Invoice invoice)
        {
            await _context.Invoices.AddAsync(invoice);

        }
    }
}
