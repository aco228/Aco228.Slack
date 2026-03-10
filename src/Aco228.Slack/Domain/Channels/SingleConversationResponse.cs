using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class SingleConversationResponse : SlackOkResponse
{
    [JsonProperty("channel")]
    public SlackChannelResponse Channel { get; set; }
}