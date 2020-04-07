using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class GetCustomerPaymentProfileResponse : BaseResponse
    {
		[JsonProperty(PropertyName = "paymentProfile")]
        public PaymentProfile PaymentProfile { get; set; }
    }
}
