using SlackDeals.Core;

namespace SlackDeals.UseCases.PluginInterfaces
{
    public interface IDataStore
    {
        Task<List<Deal>> GetDeals();
    }
}
