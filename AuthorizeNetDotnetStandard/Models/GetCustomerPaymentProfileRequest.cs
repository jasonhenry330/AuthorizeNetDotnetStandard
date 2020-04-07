using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class GetCustomerPaymentProfileRequestWrapper
    {
		[JsonProperty(PropertyName = "getCustomerPaymentProfileRequest")]
        public GetCustomerPaymentProfileRequest GetCustomerPaymentProfileRequest { get; set; }
    }
    public class DeleteCustomerPaymentProfileRequestWrapper
    {
		[JsonProperty(PropertyName = "deleteCustomerPaymentProfileRequest")]
        public GetCustomerPaymentProfileRequest GetCustomerPaymentProfileRequest { get; set; }
    }


    public class GetCustomerPaymentProfileRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        [JsonProperty(PropertyName = "customerProfileId")]
        public string CustomerProfileId { get; set; }

        [JsonProperty(PropertyName = "customerPaymentProfileId")]
        public string CustomerPaymentProfileId { get; set; }
    }
}
