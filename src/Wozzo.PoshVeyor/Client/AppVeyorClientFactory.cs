using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;

namespace Wozzo.PoshVeyor.Client
{
    public static class AppVeyorClientFactory
    {
        private const string baseUrl = "https://ci.appveyor.com";

        public static IAppVeyorClient Create(string authorizationToken)
        {
            var configuredHttpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
            configuredHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            configuredHttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);

            var appVeyorClient = RestService.For<IAppVeyorClient>(configuredHttpClient,
                new RefitSettings
                {
                    ContentSerializer = new JsonContentSerializer(
                        new JsonSerializerSettings
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        }
                    )
                });

            return appVeyorClient;
        }
    }
}