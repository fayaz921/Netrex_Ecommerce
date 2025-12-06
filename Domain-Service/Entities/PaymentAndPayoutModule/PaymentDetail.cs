using Application_Service.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application_Service.Entities.PaymentAndPayoutModule
{
    public class PaymentDetail
    {
        [Key]
        public Guid PaymentDetailId { get; set; }
        public Guid OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public PaymentStatus PaymentStatus { get; set; }
        public double AmountPaid { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
