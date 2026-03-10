using Aco228.Slack.Domain.Blocks.Core;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.Blocks.Elements;

public class TextSection : BlockBase
{
    public override string Type { get; } = "section";
    
    [JsonProperty("text")]
    public TextElement Text { get; set; }

    public TextSection(string text)
    {
        Text = new TextElement(text);
    }
}