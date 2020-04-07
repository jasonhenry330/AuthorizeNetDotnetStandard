using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreateCustomerPaymentProfile
    {
        [JsonProperty(PropertyName = "customerType", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerType { get; set; }

        [JsonProperty(PropertyName = "billTo")]
        public CustomerContact BillTo { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; set; }
    }
}
