using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class UpdateCustomerPaymentProfileResponse : BaseResponse
    {
        [JsonProperty(PropertyName = "validationDirectResponseList")]
        public string[] ValidationDirectResponseList { get; set; }
    }
}
