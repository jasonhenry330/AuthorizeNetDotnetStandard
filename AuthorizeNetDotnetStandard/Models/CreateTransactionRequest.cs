using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreateTransactionRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        [JsonProperty(PropertyName = "refId")]
        public string ReferenceId { get; set; }

        [JsonProperty(PropertyName = "transactionRequest")]
        public TransactionRequest TransactionRequest { get; set; }
    }
}