using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class ResultMessage
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}