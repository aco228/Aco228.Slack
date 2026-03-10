using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.ControllerEvents;

public record EventUponMessageRequestModel
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
        
    [JsonPropertyName("event_time")]
    public long EventTime { get; set; }
        
    [JsonPropertyName("event")]
    public EventModel? Event { get; set; }
}

public record EventModel
{
    [JsonPropertyName("client_msg_id")]
    public string ClientMessageId { get; set; }
        
    [JsonPropertyName("type")]
    public string Type { get; set; }
        
    [JsonPropertyName("user")]
    public string User { get; set; }
        
    [JsonPropertyName("ts")]
    public string ThreadId { get; set; }
        
    [JsonPropertyName("channel")]
    public string Channel { get; set; }
        
    [JsonPropertyName("text")]
    public string Text { get; set; }
        
    // TODO: Temp solution
    public string Message => new Regex("\".+\"").Match(Text).Value.Replace("\"", string.Empty);
}
