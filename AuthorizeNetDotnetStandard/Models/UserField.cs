using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class UserField
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}