using Microsoft.AspNetCore.Mvc;
using SlackDeals.Core;
using SlackDeals.UseCases.PluginInterfaces;
using SlackDeals.Plugins.DataStore.WebApi;

namespace SlackDeals.WebApi.Controllers
{
    [ApiController]
    [Route("api/deal")]
    public class DealsController : ControllerBase
    {
        private readonly IDataStore _dataStore;

        public DealsController(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public IDataStore DataStore { get; }

        [HttpGet]
        public async Task<List<Deal>> GetDeals()
        {
            return await _dataStore.GetDeals();
        }
    }
}
