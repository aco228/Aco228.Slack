using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.ControllerEvents;

public class SlackCommandControllerRequestModel
{
    [JsonPropertyName("token")]
    public string Token { get; set; }
    
    [JsonPropertyName("team_id")]
    public string TeamId { get; set; }
    
    [JsonPropertyName("channel_id")]
    public string ChannelId { get; set; }
    
    [JsonPropertyName("channel_name")]
    public string ChannelName { get; set; }
    
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }
    
    [JsonPropertyName("user_name")]
    public string Username { get; set; }
    
    [JsonPropertyName("command")]
    public string Command { get; set; }
    
    [JsonPropertyName("text")]
    public string Text { get; set; }
    
    [JsonPropertyName("api_app_id")]
    public string ApiAppId { get; set; }
    
    [JsonPropertyName("response_url")]
    public string ResponseUrl { get; set; }
    
    [JsonPropertyName("trigger_id")]
    public string TriggerId { get; set; }
}