using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class Payment
    {
		[JsonProperty(PropertyName = "creditCard")]
		public CreditCard CreditCard { get; set; }
	}
}