using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CustomerProfile
    {
        [JsonProperty(PropertyName = "customerProfileId")]
        public string CustomerProfileId { get; set; }

        [JsonProperty(PropertyName = "paymentProfile")]
        public CustomerPaymentProfile PaymentProfile { get; set; }
    }
}
