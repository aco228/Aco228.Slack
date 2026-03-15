using System.Text.Json.Serialization;
using Aco228.Slack.Domain.Blocks.Core;

namespace Aco228.Slack.Domain.PublishMessage;

public record PublishMessageRequest
{
    [JsonPropertyName("channel")]
    public string ChannelId { get; set; }
    
    [JsonPropertyName("thread_ts")]
    public string Thread { get; set; }
    
    [JsonPropertyName("text")]
    public string Message { get; set; }
    
    [JsonPropertyName("link_names")]
    public string IncludeMentions { get; set; } = "1";
    
    [JsonPropertyName("unfurl_links")]
    public bool UnfurLinks { get; set; } = false;
    
    [JsonPropertyName("blocks")]
    public List<BlockBase> Blocks { get; set; }

    [System.Text.Json.Serialization.JsonIgnore] public bool ForceSend { get; set; } = false;
}