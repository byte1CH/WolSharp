using Newtonsoft.Json;

namespace Byte1.WolSharp.Web.Models
{
    public class WakeOnLanResponse
    {
        public WakeOnLanResponse()
        {
        }

        public WakeOnLanResponse(string error)
        {
            Error = error;
        }

        [JsonProperty("success")]
        public bool Success => string.IsNullOrEmpty(Error);

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }
}