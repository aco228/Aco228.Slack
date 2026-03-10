using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Users;

public class SlackUserResponse : SlackOkResponse
{
    [JsonProperty("profile")]
    public SlackUser Profile { get; set; }
}