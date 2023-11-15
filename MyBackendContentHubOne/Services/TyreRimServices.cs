using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using MyBackendContentHubOne.GraphQL;
using MyBackendContentHubOne.Models;

namespace MyBackendContentHubOne.Services
{
    public interface ITyreRimServices
    {
        public Task<IEnumerable<TyreRim>> GetTyreRimsAsync();
    }

    public class TyreRimServices : ITyreRimServices
    {
        private readonly IConfiguration _configuration;

        public TyreRimServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<TyreRim>> GetTyreRimsAsync()
        {
            var sitecoreSettings = _configuration.GetSection("SitecoreSettings");
            var graphQlEndpoint = sitecoreSettings["SitecoreEndpointUrl"];
            var client = new GraphQLHttpClient(graphQlEndpoint, new NewtonsoftJsonSerializer());
            var query = new GraphQLRequest
            {
                Query = TyreQueries.AllTyreRims
            };

            client.HttpClient.DefaultRequestHeaders.Add("X-GQL-Token", sitecoreSettings["SitecoreDevAuthToken"]);

            var response = await client.SendQueryAsync<TyreRimData>(query);
            if (response.Data.data != null)
            {
                return response.Data.data.results;
            }
            else
            {
                return Enumerable.Empty<TyreRim>();
            }
        }
    }
}
