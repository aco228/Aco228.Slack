using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class ConversationMessagesResponse : SlackHasMoreResponse
{
    [JsonPropertyName("messages")]
    public List<SlackMessageResponse> Messages { get; set; }
}