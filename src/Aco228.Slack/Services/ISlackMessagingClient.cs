using Aco228.Common.Extensions;
using Aco228.Common.Models;
using Aco228.Slack.Domain;
using Aco228.Slack.Domain.PublishMessage;
using Aco228.Slack.Services.Api;

namespace Aco228.Slack.Services;

public interface ISlackMessagingClient : ITransient
{
    Task<PublishMessageResponse> PublishMessage(PublishMessageRequest request);
    Task<PublishMessageResponse> PublishMessage(string channel, string text, bool forceSend = false);
}

public class SlackMessagingClient : ISlackMessagingClient
{
    private readonly ISlackMessagingApiService _httpClient;
    private static ConcurrentList<SlackMessageHash> MessageHashes { get; set; } = new();
    
    
    public SlackMessagingClient (ISlackMessagingApiService httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<PublishMessageResponse> PublishMessage(PublishMessageRequest request)
    {
        RemoveOldHashes();
        var hash = SlackMessageHash.Create(request.ChannelId, request.Message);
        if (!request.ForceSend && MessageHashes.Any(x => x.Hash.Equals(hash.Hash)))
            return Task.FromResult(PublishMessageResponse.GetEmpty(request.ChannelId));
        
        if (!request.ForceSend && MessageHashes.Count(x => x.Date.GetMinutesDifference() < 1) >= 60)
            return Task.FromResult(PublishMessageResponse.GetEmpty(request.ChannelId));
        
        MessageHashes.Add(hash);
        return _httpClient.PublishMessage(request);
    }

    public Task<PublishMessageResponse> PublishMessage(string channel, string text, bool forceSend = false)
    {
        return PublishMessage(new()
        {
            ChannelId = channel,
            Message = text,
            ForceSend = forceSend,
        });
    }

    public static void RemoveOldHashes()
    {
        foreach (var message in MessageHashes.ToConcurrentList())
            if (message.Date.GetMinutesDifference() > 15)
                MessageHashes.Remove(message);
    }
}