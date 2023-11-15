using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using MyBackendContentHubOne.GraphQL;
using MyBackendContentHubOne.Models;

namespace MyBackendContentHubOne.Services
{
    public interface ITyreServices
    {
        public Task<IEnumerable<Tyre>> GetAllTyresAsync();
    }

    public class TyreServices : ITyreServices
    {
        private readonly IConfiguration _configuration;

        public TyreServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Tyre>> GetAllTyresAsync()
        {
            var sitecoreSettings = _configuration.GetSection("SitecoreSettings");
            var graphQlEndpoint = sitecoreSettings["SitecoreEndpointUrl"];
            var client = new GraphQLHttpClient(graphQlEndpoint, new NewtonsoftJsonSerializer());
            var query = new GraphQLRequest
            {
                Query = TyreQueries.AllTyres
            };

            client.HttpClient.DefaultRequestHeaders.Add("X-GQL-Token", sitecoreSettings["SitecoreDevAuthToken"]);

            var response = await client.SendQueryAsync<TyreData>(query);
            if (response.Data.data != null)
            {
                return response.Data.data.results;
            }
            else
            {
                return Enumerable.Empty<Tyre>();
            }
        }
    }
}
