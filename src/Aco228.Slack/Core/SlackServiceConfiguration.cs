using Aco228.Common.Services;
using Aco228.WService.Base;

namespace Aco228.Slack.Core;

public class SlackServiceConfiguration : ApiServiceConf
{
    public override string BaseUrl => "https://slack.com/api/";
    private static string ApiKey { get; set; }

    public SlackServiceConfiguration(ISecretProvider secretProvider)
    {
        ApiKey = secretProvider.Get("SLACK_API_KEY");
    }

    public override HttpClient Prepare(HttpClient httpClient)
    {
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
        return httpClient;
    }
}