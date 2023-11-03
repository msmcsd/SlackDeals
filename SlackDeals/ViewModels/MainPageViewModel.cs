using SlackDeals.Core;
using SlackDeals.UseCases;
using SlackDeals.UseCases.Interfaces;
using System.Collections.ObjectModel;

namespace SlackDeals.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IViewDeals _viewDeals;

        public ObservableCollection<Deal> Deals { get; set; } = new();

        public MainPageViewModel(IViewDeals viewDeals)
        {
            _viewDeals = viewDeals;
        }
        public async Task LoadDeals()
        {
            if (Deals.Count != 0) 
            { 
                Deals.Clear();
            }

            var deals = await _viewDeals.ExecuteAsync();

            foreach(var deal in deals)
            {
                Deals.Add(deal);
            }
        }
    }
}
