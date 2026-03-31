using Aco228.Slack.Domain.Actions;

namespace Aco228.Slack.Services;

public interface ISlackActionEventSubscriberService
{
    public Task OnAppMention(SlackActionRequest request);
}