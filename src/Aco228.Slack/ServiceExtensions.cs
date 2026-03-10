using Aco228.Common.Extensions;
using Aco228.Common.Infrastructure;
using Aco228.Slack.Core;
using Aco228.Slack.Services;
using Aco228.WService;
using Microsoft.Extensions.DependencyInjection;

namespace Aco228.Slack;

public static class ServiceExtensions
{
    public static void RegisterSlack(this IServiceCollection service)
        => typeof(ServiceExtensions).RegisterIfNot(() =>
        {
            service.RegisterApiServices(typeof(SlackServiceConfiguration).Assembly);
            service.RegisterServicesFromAssembly(typeof(SlackServiceConfiguration).Assembly);
            service.AddTransient<ISlackMessagingClient, SlackMessagingClient>();
        });
}