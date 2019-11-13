namespace ExchangeRate.NbpClient
{
    using System;
    using Abstractions;
    using Microsoft.Extensions.DependencyInjection;
    using Polly;

    public static class NbpClientConfiguration
    {
        private const string NbpUrl = "https://api.nbp.pl/";

        public static void AddNbpClient(this IServiceCollection services)
        {
            services
                .AddHttpClient<INbpClient, NbpClient>("NbpClient", client =>
                {
                    client.BaseAddress = new Uri(NbpUrl, UriKind.Absolute);
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                })
                .AddTransientHttpErrorPolicy(builder => builder.WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(retryAttempt)))
                .SetHandlerLifetime(TimeSpan.FromMinutes(5));
        }
    }
}
