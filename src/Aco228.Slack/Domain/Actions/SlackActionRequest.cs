using System.Text.Json.Serialization;

namespace Aco228.Slack.Domain.Actions;

public class SlackActionRequest
{
    public string token { get; set; }
    public string team_id { get; set; }
    public string api_app_id { get; set; }
    [JsonPropertyName("event")]
    public EventDTO Event { get; set; }
    public string type { get; set; }
    public string event_id { get; set; }
    public int event_time { get; set; }
    public List<AuthorizationDTO> authorizations { get; set; }
    public bool is_ext_shared_channel { get; set; }
    public string event_context { get; set; }
}


public class ElementDTO
{
    public string type { get; set; }
    public List<ElementDTO> elements { get; set; }
}

public class BlockDTO
{
    public string type { get; set; }
    public string block_id { get; set; }
    public List<ElementDTO> elements { get; set; }
}

public class EventDTO
{
    public string type { get; set; }
    public string user { get; set; }
    public string ts { get; set; }
    public string? thread_ts { get; set; }
    public string client_msg_id { get; set; }
    public string text { get; set; }
    public string team { get; set; }
    public List<BlockDTO> blocks { get; set; }
    public string channel { get; set; }
    public string event_ts { get; set; }
}

public class AuthorizationDTO
{
    public object enterprise_id { get; set; }
    public string team_id { get; set; }
    public string user_id { get; set; }
    public bool is_bot { get; set; }
    public bool is_enterprise_install { get; set; }
}
