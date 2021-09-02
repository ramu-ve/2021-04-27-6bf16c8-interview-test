using Newtonsoft.Json;

namespace Aris.ServerTest.Models
{
    public class KoreAttributes
    {
        [JsonProperty("free_spins")]
        public string FreeSpins { get; set; }
    }
}
