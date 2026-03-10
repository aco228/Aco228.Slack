using Newtonsoft.Json;

namespace Aco228.Slack.Domain;

public class SlackOkResponse
{
    [JsonProperty("ok")]
    public bool Ok { get; set; }
}