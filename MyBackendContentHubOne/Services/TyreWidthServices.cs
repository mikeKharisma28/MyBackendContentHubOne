using MyBackendContentHubOne.Models;
using System.Net.Http;
using GraphQL.Client;

namespace MyBackendContentHubOne.Services
{
    public interface ITyreWidthServices
    {
        public IEnumerable<TyreWidths> GetTyreWidths();
    }

    public class TyreWidthServices : ITyreWidthServices
    {
        public TyreWidthServices() { }

        public IEnumerable<TyreWidths> GetTyreWidths() 
        {
            var graphQlEndpoint = new Uri(""); 

            return new List<TyreWidths>();
        }
    }
}
