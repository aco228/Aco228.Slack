using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Blocks.Core;

public class TextElement : BlockBase
{
    public override string Type { get; } = "mrkdwn";
    
    [JsonProperty("text")]
    public string Text { get; set; }

    public TextElement(string text)
    {
        Text = text;
    }
}