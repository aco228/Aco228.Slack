using Aco228.Slack.Domain.Blocks.Core;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Blocks.Elements;

public class ContextSection : BlockBase
{
    public override string Type { get; } = "context";

    [JsonProperty("elements")] public List<BlockBase> Elements { get; set; } = new();
}