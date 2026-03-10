using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Blocks.Core;

public abstract class BlockBase
{
    [JsonProperty("type")]
    public abstract string Type { get; }
        
    [JsonProperty("block_id", NullValueHandling = NullValueHandling.Ignore)]
    public string BlockId { get; set; }
}