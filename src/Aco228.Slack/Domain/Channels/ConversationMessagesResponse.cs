using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class ConversationMessagesResponse : SlackHasMoreResponse
{
    [JsonProperty("messages")]
    public List<SlackMessageResponse> Messages { get; set; }
}