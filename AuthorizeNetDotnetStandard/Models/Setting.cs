using Newtonsoft.Json;

namespace AuthorizeNetDotnetStandard.Models
{
    public class Setting
    {
        [JsonProperty(PropertyName = "settingName")]
        public string SettingName { get; set; }

        [JsonProperty(PropertyName = "settingValue")]
        public string SettingValue { get; set; }
    }
}