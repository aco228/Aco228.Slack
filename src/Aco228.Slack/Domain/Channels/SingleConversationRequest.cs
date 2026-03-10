using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class SingleConversationRequest
{
    [JsonProperty("channel")]
    public string Channel { get; set; }
}