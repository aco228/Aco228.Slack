using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class SingleConversationResponse : SlackOkResponse
{
    [JsonPropertyName("channel")]
    public SlackChannelResponse Channel { get; set; }
}