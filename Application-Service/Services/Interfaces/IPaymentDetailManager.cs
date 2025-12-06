using Application_Service.DTO_s.PaymentAndPayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Services.Interfaces
{
    public interface IPaymentDetailManager
    {
        Task AddPaymentDetailAsync(AddPaymentDetailDto dto);
    }
}
