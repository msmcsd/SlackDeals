using SlackDeals.Core;

namespace SlackDeals.UseCases.Interfaces
{
    public interface IViewDeals
    {
        Task<List<Deal>> ExecuteAsync();
    }
}