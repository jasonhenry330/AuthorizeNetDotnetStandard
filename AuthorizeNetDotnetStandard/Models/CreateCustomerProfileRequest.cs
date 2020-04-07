using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreateCustomerProfileRequestWrapper
    {
        [JsonProperty(PropertyName = "createCustomerProfileRequest")]
        public CreateCustomerProfileRequest CreateCustomerProfileRequest { get; set; }
    }

    public class CreateCustomerProfileRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        [JsonProperty(PropertyName = "profile")]
        public CreateCustomerProfile CreateCustomerProfile { get; set; }

        [JsonProperty(PropertyName = "validationMode", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationMode { get; set; }
    }
}
