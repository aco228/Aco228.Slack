using Aco228.Slack.Core;
using Aco228.Slack.Domain.Channels;
using Aco228.WService;
using Aco228.WService.Models.Attributes.MethodAttributes;

namespace Aco228.Slack.Services.Api;

public interface ISlackConversationApiService : ISlackApiService
{
    [ApiGet("conversations.info")]
    public Task<SingleConversationResponse> GetConversation(SingleConversationRequest request);

    [ApiGet("conversations.list")]
    public Task<ConversationListResponse> GetConversationList(ConversationListRequest request);

    [ApiGet("conversations.history")]
    public Task<ConversationMessagesResponse> GetMessages(ConversationMessagesRequest request);
}