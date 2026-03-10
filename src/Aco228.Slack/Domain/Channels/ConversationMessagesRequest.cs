using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class ConversationMessagesRequest
{
    [JsonPropertyName("limit")]
    public int Limit { get; set; } = 100;
    
    [JsonPropertyName("channel")]
    public string Channel { get; set; }
    
    [JsonPropertyName("latest")]
    public string LatestMessageThread { get; set; }
    
    [JsonPropertyName("oldest")]
    public string OldestMessageThread { get; set; }
}