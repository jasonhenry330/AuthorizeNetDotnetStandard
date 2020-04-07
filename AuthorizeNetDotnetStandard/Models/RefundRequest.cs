using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class RefundRequest
    {
        [JsonProperty(PropertyName = "createTransactionRequest")]
        public CreateTransactionRequest CreateTransactionRequest { get; set; }
    }
}