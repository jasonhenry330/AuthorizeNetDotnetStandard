using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class TransactionRequest
    {
        [JsonProperty(PropertyName = "transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "payment", NullValueHandling = NullValueHandling.Ignore)]
        public Payment Payment { get; set; }

        [JsonProperty(PropertyName = "profile", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerProfile Profile { get; set; }

        [JsonProperty(PropertyName = "order", NullValueHandling = NullValueHandling.Ignore)]
        public Order Order { get; set; }

        [JsonProperty(PropertyName = "refTransId", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceTransactionId { get; set; }

        [JsonProperty(PropertyName = "billTo", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerContact BillTo { get; set; }

        [JsonProperty(PropertyName = "customerIP")]
        public string CustomerIP { get; set; }

        [JsonProperty(PropertyName = "transactionSettings")]
        public TransactionSettings TransactionSettings { get; set; }

        [JsonProperty(PropertyName = "userFields")]
        public UserFields UserFields { get; set; }
    }
}