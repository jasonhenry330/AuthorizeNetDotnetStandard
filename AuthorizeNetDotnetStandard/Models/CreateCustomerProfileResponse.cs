using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreateCustomerProfileResponse : BaseResponse
    {
        [JsonProperty(PropertyName = "customerProfileId")]
        public string CustomerProfileId { get; set; }

        [JsonProperty(PropertyName = "customerPaymentProfileIdList")]
        public string[] CustomerPaymentProfileIdList { get; set; }

        [JsonProperty(PropertyName = "customerShippingAddressIdList")]
        public string[] CustomerShippingAddressIdList { get; set; }

        [JsonProperty(PropertyName = "validationDirectResponseList")]
        public string[] ValidationDirectResponseList { get; set; }
    }
}
