using SlackDeals.Core;
using SlackDeals.UseCases.Interfaces;
using SlackDeals.UseCases.PluginInterfaces;

namespace SlackDeals.UseCases.UseCases
{
    public class ViewDeals : IViewDeals
    {
        private readonly IDataStore _dataStore;

        public ViewDeals(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<List<Deal>> ExecuteAsync()
        {
            return await _dataStore.GetDeals();
        }
    }
}
