using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookDataExplorer.Models.Data
{
    /// <summary>
    /// For
    /// advertisers_who_uploaded_a_contact_list_with_your_information.json
    /// advertisers_you've_interacted_with.json
    /// </summary>
    public partial class AdvertiserrRoot
    {
        [JsonProperty("topics")]
        public List<object> Topics { get; set; }

        [JsonProperty("custom_audiences")]
        public List<string> CustomAudiences { get; set; }

        [JsonProperty("lead_gen_info")]
        public List<object> LeadGenInfo { get; set; }

        [JsonProperty("history")]
        public List<object> History { get; set; }
    }
}
