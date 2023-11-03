using SlackDeals.ViewModels;

namespace SlackDeals
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _mainPageViewModel;

        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            _mainPageViewModel = mainPageViewModel;
            BindingContext = _mainPageViewModel;
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            _mainPageViewModel.LoadDeals();
        }
    }
}