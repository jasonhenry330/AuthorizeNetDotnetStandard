using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class UpdateCustomerPaymentProfileRequestWrapper
    {
        [JsonProperty(PropertyName = "updateCustomerPaymentProfileRequest")]
        public UpdateCustomerPaymentProfileRequest UpdateCustomerPaymentProfileRequest { get; set; }
    }

    public class UpdateCustomerPaymentProfileRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        [JsonProperty(PropertyName = "customerProfileId")]
        public string CustomerProfileId { get; set; }

        [JsonProperty(PropertyName = "paymentProfile")]
        public PaymentProfile PaymentProfile { get; set; }

        [JsonProperty(PropertyName = "validationMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationMode { get; set; }
    }
}
