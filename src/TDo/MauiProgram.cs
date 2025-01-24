using Microsoft.Extensions.Logging;
using TDo.ViewModels;


namespace TDo
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
                });

            builder.Services.AddMauiBlazorWebView();
			builder.Services.AddSingleton<TaskBlockViewModel>();

#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            //tutaj doda sie DI dla naszych servisuw i viewmodels

            return builder.Build();
        }
    }
}
