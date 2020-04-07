using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
	public class ChargeCreditCardResponse : BaseResponse
	{

		[JsonProperty(PropertyName = "transactionResponse")]
		public TransactionResponse TransactionResponse { get; set; }

	}
}