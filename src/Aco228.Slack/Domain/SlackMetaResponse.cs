using Newtonsoft.Json;

namespace Aco228.Slack.Domain;

public class SlackMetaResponse : SlackOkResponse
{
    [JsonProperty("response_metadata")] 
    public SlackMetaResponseMetadata Metadata { get; set; } = new ();
}

public class SlackMetaResponseMetadata
{
    [JsonProperty("next_cursor")]
    public string NextCursor { get; set; }
}