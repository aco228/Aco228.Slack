using System.Collections.Concurrent;

namespace Aco228.Slack.Domain.PublishMessage;

public class SlackMessageGroup
{
    public ConcurrentDictionary<string, List<string>> Messages { get; set; } = new();

    public bool Any() => Messages.Any();
}

public static class SlackMessageGroupExtensions
{
    public static void Add(this SlackMessageGroup group, string groupName, string message)
    {
        if(!group.Messages.ContainsKey(groupName))
            group.Messages.TryAdd(groupName, new());
        
        group.Messages[groupName].Add(message);
    }
}