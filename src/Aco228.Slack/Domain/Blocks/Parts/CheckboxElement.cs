using Aco228.Slack.Domain.Blocks.Core;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Blocks.Parts;

public class CheckboxElement : BlockBase
{
    public override string Type { get; } = "checkboxes";
        
    public List<CheckboxOption> Options { get; set; } = new();
        
    [JsonProperty("action_id")]
    public string ActionId { get; set; }
        
}