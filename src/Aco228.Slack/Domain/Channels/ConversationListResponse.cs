using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public class ConversationListResponse : SlackMetaResponse
{
    [JsonProperty("channels")]
    public List<SlackChannelResponse> Channels { get; set; }
}