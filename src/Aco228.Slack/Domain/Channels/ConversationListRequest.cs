
using System.Text.Json.Serialization;

namespace Aco228.Slack.Domain.Channels;

public class ConversationListRequest
{
    [JsonIgnore]
    public bool ExcludeArchived { get; set; } = true;
    
    [JsonIgnore]
    public List<SlackChannelType> Types { get; set; } = new() { SlackChannelType.public_channel, SlackChannelType.private_channel };
    
    [JsonPropertyName("limit")]
    public int Limit { get; set; } = 100;
    
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }

    [JsonPropertyName("exclude_archived")] 
    public string  Arg_ExcludeArchived => ExcludeArchived ? "true" : "false";

    [JsonPropertyName("types")]
    public string Arg_Types
    {
        get
        {
            var result = "";
            foreach (var type in Types)
                result += (!string.IsNullOrEmpty(result) ? "," : "") + type.ToString();
            return result;
        }
    }
}