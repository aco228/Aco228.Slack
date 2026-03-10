using Aco228.Slack.Domain.Blocks.Core;
using Aco228.Slack.Domain.Blocks.Parts;

namespace Aco228.Slack.Domain.Blocks.Elements;

public class Checkbox : ActionElement<CheckboxElement>
{
    public Checkbox(string actionName)
    {
        Elements.Add(new CheckboxElement
        {
            ActionId = actionName
        });
    }

    public void Add(CheckboxOption checkbox)
        => Elements.FirstOrDefault().Options.Add(checkbox);
}