using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class PaymentProfile
    {
		[JsonProperty(PropertyName = "customerProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerProfileId { get; set; }

        [JsonProperty(PropertyName = "billTo")]
        public CustomerContact BillTo { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; set; }

        [JsonProperty(PropertyName = "customerType", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerType { get; set; }

        [JsonProperty(PropertyName = "customerPaymentProfileId")]
        public string CustomerPaymentProfileId { get; set; }
    }
}