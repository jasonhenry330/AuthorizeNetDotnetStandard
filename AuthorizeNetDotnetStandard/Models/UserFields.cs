using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class UserFields
    {
        [JsonProperty(PropertyName = "userField")]
        public UserField[] UserField { get; set; }
    }
}