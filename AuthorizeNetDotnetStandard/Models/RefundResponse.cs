using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class RefundResponse : BaseResponse
    {

        [JsonProperty(PropertyName = "transactionResponse")]
        public TransactionResponse TransactionResponse { get; set; }

    }
}