using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class CreditCard
    {
        [JsonProperty(PropertyName = "cardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty(PropertyName = "expirationDate")]
        public string ExpirationDate { get; set; }

		[JsonProperty(PropertyName = "cardCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CardCode { get; set; }

		[JsonProperty(PropertyName = "cardType", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; set; }
	}
}