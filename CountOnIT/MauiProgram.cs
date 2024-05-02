using CountOnIT.Interfaces;
using CountOnIT.Models;
using CountOnIT.Services;
using CountOnIT.ViewModels;
using CountOnIT.Views;
using Microsoft.Extensions.Logging;

namespace CountOnIT
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

            builder.Services.AddSingleton<IShoppingService>(new ShoppingServiceMock());
            builder.Services.AddSingleton(new ShoppingCartViewModel(new ShoppingCart()));
            builder.Services.AddTransient<UsagePage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
