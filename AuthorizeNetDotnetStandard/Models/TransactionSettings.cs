using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class TransactionSettings
    {
        [JsonProperty(PropertyName = "settingName")]
        public Setting[] Setting { get; set; }
    }
}