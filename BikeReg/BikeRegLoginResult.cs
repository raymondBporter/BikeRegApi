using Newtonsoft.Json;

namespace BikeReg
{

    public class BikeRegLoginResult
    {
        public string Status { get; set; }
        [JsonProperty("promoterID")]
        public string PromoterID { get; set; }
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
    }
    
}
