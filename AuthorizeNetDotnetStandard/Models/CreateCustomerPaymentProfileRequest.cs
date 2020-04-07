using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreateCustomerPaymentProfileRequestWrapper
    {
        [JsonProperty(PropertyName = "createCustomerPaymentProfileRequest")]
        public CreateCustomerPaymentProfileRequest CreateCustomerPaymentProfileRequest { get; set; }
    }

    public class CreateCustomerPaymentProfileRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        [JsonProperty(PropertyName = "customerProfileId")]
        public string CustomerProfileId { get; set; }

        [JsonProperty(PropertyName = "paymentProfile")]
        public CreateCustomerPaymentProfile CreateCustomerPaymentProfile { get; set; }

        [JsonProperty(PropertyName = "validationMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationMode { get; set; }
    }
}
