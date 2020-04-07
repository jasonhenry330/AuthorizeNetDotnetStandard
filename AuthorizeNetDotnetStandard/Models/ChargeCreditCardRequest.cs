using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class ChargeCreditCardRequest
    {
        [JsonProperty(PropertyName = "createTransactionRequest")]
        public CreateTransactionRequest CreateTransactionRequest { get; set; }
    }
}