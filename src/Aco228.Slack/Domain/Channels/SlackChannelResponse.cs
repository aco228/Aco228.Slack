using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Channels;

public enum SlackChannelType
{
    public_channel,
    private_channel,
    mpim,
    im,
}

public class SlackChannelResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("name_normalized")]
    public string NameNormalized { get; set; }
    
    [JsonPropertyName("is_channel")]
    public bool IsChannel { get; set; }
    
    [JsonPropertyName("is_group")]
    public bool IsGroup { get; set; }
    
    [JsonPropertyName("is_archived")]
    public bool IsArchived { get; set; }
    
    [JsonPropertyName("is_private")]
    public bool IsPrivate { get; set; }
    
    [JsonPropertyName("is_member")]
    public bool IsMember { get; set; }
}