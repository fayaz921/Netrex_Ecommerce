using Application_Service.Common.Mappers.PaymentAndPayout;
using Application_Service.DTO_s.PaymentAndPayout;
using Application_Service.Services.PaymentAndPayoutService.Interfaces;
using Domain_Service.RepoInterfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.PaymentAndPayoutService.Implementation
{
    public class PaymentDetailManager : IPaymentDetailManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentDetailManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddPaymentDetailAsync(AddPaymentDetailDto dto)
        {
            var paymentDetail = dto.Map();
            await _unitOfWork.PaymentDetails.Create(paymentDetail);
            var result = await _unitOfWork.SaveChangesAsync();
        }
    }
}
