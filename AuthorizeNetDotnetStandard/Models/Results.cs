using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class Results
    {
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; set; }

        [JsonProperty(PropertyName = "message")]
        public ResultMessage[] ResultMessages { get; set; }
    }
}