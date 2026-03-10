using Aco228.WService.Attributes;
using Aco228.WService.Base;

namespace Aco228.Slack.Core;

[ApiServiceDecorator(typeof(SlackServiceConfiguration))]
public interface ISlackApiService : IApiService
{
    
}