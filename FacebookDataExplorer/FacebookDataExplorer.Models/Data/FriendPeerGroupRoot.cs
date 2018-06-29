using Newtonsoft.Json;

namespace FacebookDataExplorer.Models.Data
{
    /// <summary>
    /// For
    /// friend_peer_group.json
    /// </summary>
    public class FriendPeerGroupRoot
    {
        [JsonProperty("friend_peer_group")]
        public string FriendPeerGroup { get; set; }
    }
}
