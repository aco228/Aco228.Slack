using Aco228.Common;
using Aco228.Slack.Services;
using Newtonsoft.Json;

namespace Aco228.Slack.Domain.PublishMessage;

public class PublishMessageResponse
{
    public bool ok { get; set; }
    public string channel { get; set; }
    public string ts { get; set; }

    public async Task PublishMessage(string message, bool forceSend = true)
    {
        var service = ServiceProviderHelper.GetService<ISlackMessagingClient>();
        if (service == null)
            return;
        
        if(string.IsNullOrEmpty(ts))
            return;

        await service.PublishMessage(new()
        {
            ChannelId = channel,
            Thread = ts,
            Message = message,
            ForceSend = forceSend,
        });
    }

    public static PublishMessageResponse GetEmpty(string channelId)
        => new PublishMessageResponse()
        {
            channel = channelId,
            ok = false,
            ts = string.Empty,
        };
}