using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CustomerPaymentProfile
    {
        [JsonProperty(PropertyName = "paymentProfileId")]
        public string PaymentProfileId { get; set; }
    }
}
