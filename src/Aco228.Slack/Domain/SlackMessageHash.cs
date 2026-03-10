using Aco228.Common.Extensions;

namespace Aco228.Slack.Domain;

public class SlackMessageHash
{
    public string Hash { get; set; }
    public DateTime Date { get; set; }

    public static SlackMessageHash Create(string channel, string message)
    {
        var hash = StringExtensions.ToSha256($"{channel}-{message}");
        return new()
        {
            Date = DateTime.Now,
            Hash = hash
        };
    }
}