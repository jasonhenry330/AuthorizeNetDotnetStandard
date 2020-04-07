using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class MerchantAuthentication
    {
        [JsonProperty(PropertyName = "name")]
        public string LoginId { get; set; }

        [JsonProperty(PropertyName = "transactionKey")]
        public string TransactionKey { get; set; }
    }
}