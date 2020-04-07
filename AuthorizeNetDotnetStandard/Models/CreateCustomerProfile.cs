using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreateCustomerProfile
    {
        [JsonProperty(PropertyName = "merchantCustomerId", NullValueHandling = NullValueHandling.Ignore)]
        public string MerchantCustomerId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "paymentProfiles", NullValueHandling = NullValueHandling.Ignore)]
        public CreateCustomerPaymentProfile CreateCustomerPaymentProfile { get; set; }
    }
}