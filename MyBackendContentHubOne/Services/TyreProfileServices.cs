using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using MyBackendContentHubOne.GraphQL;
using MyBackendContentHubOne.Models;

namespace MyBackendContentHubOne.Services
{
    public interface ITyreProfileServices
    {
        public Task<IEnumerable<TyreProfile>> GetTyreProfilesAsync();
    }

    public class TyreProfileServices : ITyreProfileServices
    {
        private readonly IConfiguration _configuration;

        public TyreProfileServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<TyreProfile>> GetTyreProfilesAsync()
        {
            var sitecoreSettings = _configuration.GetSection("SitecoreSettings");
            var graphQlEndpoint = sitecoreSettings["SitecoreEndpointUrl"];
            var client = new GraphQLHttpClient(graphQlEndpoint, new NewtonsoftJsonSerializer());
            var query = new GraphQLRequest
            {
                Query = TyreQueries.AllTyreProfiles
            };

            client.HttpClient.DefaultRequestHeaders.Add("X-GQL-Token", sitecoreSettings["SitecoreDevAuthToken"]);

            var response = await client.SendQueryAsync<TyreProfileData>(query);
            if (response.Data.data != null)
            {
                return response.Data.data.results;
            }
            else
            {
                return Enumerable.Empty<TyreProfile>();
            }
        }
    }
}
