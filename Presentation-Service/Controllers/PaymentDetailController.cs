using Application_Service.DTO_s.PaymentAndPayout;
using Application_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly IPaymentDetailManager _paymentDetailManager;
        public PaymentDetailController(IPaymentDetailManager paymentDetailManager)
        {
            _paymentDetailManager = paymentDetailManager;
        }
        [HttpPost("ProcessPayment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ProcessPayment([FromBody]AddPaymentDetailDto dto)
        {
            await _paymentDetailManager.AddPaymentDetailAsync(dto);
            return Created("", "Payment processed successfully (mock integration)");
        }
    }
}
