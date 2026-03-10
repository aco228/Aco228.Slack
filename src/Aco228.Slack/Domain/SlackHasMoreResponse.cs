using Newtonsoft.Json;

namespace Aco228.Slack.Domain;

public class SlackHasMoreResponse : SlackOkResponse
{
    [JsonProperty("has_more")]
    public bool HasMore { get; set; }
}