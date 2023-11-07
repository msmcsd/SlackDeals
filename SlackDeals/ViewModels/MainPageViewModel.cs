using SlackDeals.Core;
using SlackDeals.UseCases;
using SlackDeals.UseCases.Interfaces;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;

namespace SlackDeals.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly IViewDeals _viewDeals;

        public ObservableCollection<Deal> Deals { get; set; } = new();

        public MainPageViewModel(IViewDeals viewDeals)
        {
            _viewDeals = viewDeals;
        }

        [RelayCommand]
        public async Task LoadDeals()
        {
            IsBusy = true;

            if (Deals.Count != 0) 
            { 
                Deals.Clear();
            }

            try
            {
                var deals = await _viewDeals.ExecuteAsync();

                foreach (var deal in deals)
                {
                    Deals.Add(deal);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
