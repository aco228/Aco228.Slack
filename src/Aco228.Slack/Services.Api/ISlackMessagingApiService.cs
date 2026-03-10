using Aco228.Slack.Core;
using Aco228.Slack.Domain.PublishMessage;
using Aco228.WService;

namespace Aco228.Slack.Services.Api;

public interface ISlackMessagingApiService : ISlackApiService
{
    [ApiPost("chat.postMessage")]
    public Task<string> PublishMessageAndGetRaw(PublishMessageRequest request);
    
    [ApiPost("chat.postMessage")]
    public Task<PublishMessageResponse> PublishMessage(PublishMessageRequest request);
}