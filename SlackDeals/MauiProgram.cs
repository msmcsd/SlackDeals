using Microsoft.Extensions.Logging;
using SlackDeals.UseCases.Interfaces;
using SlackDeals.UseCases.PluginInterfaces;
using SlackDeals.UseCases.UseCases;
using SlackDeals.ViewModels;
using SlackDeals.Plugins.DataStore.InMemory;
using SlackDeals.Plugins.DataStore.WebApi;

namespace SlackDeals
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<IDataStore, InMemoryDataStore>();
            //builder.Services.AddTransient<IDataStore, WebApiDataStore>();
            builder.Services.AddTransient<IViewDeals, ViewDeals>();

            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<MainPage>();

            return builder.Build();
        }
    }
}