﻿using MyBackendContentHubOne.Models;
using System.Net.Http;
using GraphQL.Client;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL;
using MyBackendContentHubOne.GraphQL;

namespace MyBackendContentHubOne.Services
{
    public interface ITyreWidthServices
    {
        public Task<IEnumerable<TyreWidth>> GetTyreWidthsAsync();
    }

    public class TyreWidthServices : ITyreWidthServices
    {
        private readonly IConfiguration _configuration;

        public TyreWidthServices(IConfiguration configuration) 
        { 
            _configuration = configuration;
        }

        public async Task<IEnumerable<TyreWidth>> GetTyreWidthsAsync() 
        {
            var sitecoreSettings = _configuration.GetSection("SitecoreSettings");
            var graphQlEndpoint = sitecoreSettings["SitecoreEndpointUrl"];
            var client = new GraphQLHttpClient(graphQlEndpoint, new NewtonsoftJsonSerializer());
            var query = new GraphQLRequest
            {
                Query = TyreQueries.AllTyreWidths
            };

            client.HttpClient.DefaultRequestHeaders.Add("X-GQL-Token", sitecoreSettings["SitecoreDevAuthToken"]);

            var response = await client.SendQueryAsync<TyreWidthData>(query);
            if (response.Data.data != null)
            {
                return response.Data.data.results;
            }
            else
            {
                return Enumerable.Empty<TyreWidth>();
            }
        }
    }
}
