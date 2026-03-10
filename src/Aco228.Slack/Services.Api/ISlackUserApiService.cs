using Aco228.Slack.Core;
using Aco228.Slack.Domain.Users;
using Aco228.WService.Models.Attributes.MethodAttributes;

namespace Aco228.Slack.Services.Api;

public interface ISlackUserApiService : ISlackApiService
{
    [ApiGet("users.profile.get?user={user}")]
    public Task<SlackUserResponse?> GetUserInformations(string user);
}