using SlackDeals.Core;
using SlackDeals.UseCases.PluginInterfaces;
using MongoDB.Driver;

namespace SlackDeals.Plugins.DataStore.WebApi
{
    // All the code in this file is included in all platforms.
    public class WebApiDataStore : IDataStore
    {
        private string connection_string = Environment.GetEnvironmentVariable("SlackDeals", EnvironmentVariableTarget.User);
        private readonly IMongoDatabase _db;
        public WebApiDataStore()
        {
            MongoClient client = new(connection_string);
            _db = client.GetDatabase("slack_deals");
        }

        public async Task<List<Deal>> GetDeals()
        {
            var doc = _db?.GetCollection<Deal>("deals");
            if (doc == null)
            {
                return new List<Deal>();
            }

            return doc.AsQueryable().ToList();
        }
    }
}