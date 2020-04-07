using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreateCustomerPaymentProfileResponse : BaseResponse
    {
        [JsonProperty(PropertyName = "customerProfileId")]
        public string CustomerProfileId { get; set; }

        [JsonProperty(PropertyName = "customerPaymentProfileId")]
        public string CustomerPaymentProfileId { get; set; }

        [JsonProperty(PropertyName = "validationDirectResponse")]
        public string ValidationDirectResponse { get; set; }
    }
}
