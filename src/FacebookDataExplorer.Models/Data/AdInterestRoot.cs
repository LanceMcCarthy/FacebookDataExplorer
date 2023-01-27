using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FacebookDataExplorer.Models.Data
{
    /// <summary>
    /// For
    /// ads_interest.json
    /// </summary>
    public partial class AdInterestRoot
    {
        [JsonProperty("topics")]
        public List<string> Topics { get; set; }

        [JsonProperty("custom_audiences")]
        public List<object> CustomAudiences { get; set; }

        [JsonProperty("lead_gen_info")]
        public List<object> LeadGenInfo { get; set; }

        [JsonProperty("history")]
        public List<object> History { get; set; }
    }
}
