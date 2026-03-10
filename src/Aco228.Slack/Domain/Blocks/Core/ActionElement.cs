using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Blocks.Core;

public abstract class ActionElement<T> : BlockBase
{
    public override string Type { get; } = "actions";
        
    [JsonProperty("elements")]
    public List<T> Elements { get; set; } = new();
}