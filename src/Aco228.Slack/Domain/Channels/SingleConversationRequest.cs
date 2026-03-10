using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class SingleConversationRequest
{
    [JsonPropertyName("channel")]
    public string Channel { get; set; }
}