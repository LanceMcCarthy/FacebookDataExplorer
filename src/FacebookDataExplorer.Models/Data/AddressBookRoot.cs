using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacebookDataExplorer.Models.Data
{
    /// <summary>
    /// For
    /// your_address_books.json
    /// </summary>
    public class AddressBookRoot
    {
        [JsonProperty("address_book")]
        public AddressBookBase AddressBook { get; set; }
    }

    public class AddressBookBase
    {
        [JsonProperty("address_book")]
        public List<AddressBookElement> AddressBook { get; set; }
    }

    public class AddressBookElement
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("details")]
        public List<Detail> Details { get; set; }

        [JsonProperty("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        [JsonProperty("updated_timestamp")]
        public long UpdatedTimestamp { get; set; }
    }

    public class Detail
    {
        [JsonProperty("contact_point")]
        public string ContactPoint { get; set; }
    }
}
