using Application_Service.Entities.PaymentAndPayoutModule;

namespace Application_Service.RepoInterfaces.PaymentAndPayout
{
    public interface IInvoiceRepo
    {
        public Task CreateInvoice(Invoice invoice);
    }
}
