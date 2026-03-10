using Aco228.Slack.Domain.ControllerEvents;

namespace Aco228.Slack.Extensions;

public static class SlackGlobalExtensions
{
    public static string ToSlackLink(this string link, string text)
        => $"<{link}|{text}>";
    
    public static bool IsValid(this EventUponMessageRequestModel? input)
        => input != null && input.Event != null && !string.IsNullOrEmpty(input.Event.Text);
}