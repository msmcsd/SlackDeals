using SlackDeals.Core;

namespace SlackDeals.UseCases.PluginInterfaces
{
    public interface IDataStore
    {
        List<Deal> GetDeals();
    }
}
