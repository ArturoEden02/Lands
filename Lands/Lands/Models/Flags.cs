namespace Lands.Models
{
    using Newtonsoft.Json;

    public class Flags
    {
        [JsonProperty(PropertyName = "svg")]
        public string Svg { get; set; }

        [JsonProperty(PropertyName = "png")]
        public string Png { get; set; }
    }
}