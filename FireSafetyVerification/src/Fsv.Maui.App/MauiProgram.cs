using Fsv.Common.Bll.Abstractions;
using Fsv.Common.Bll.Services;
using Fsv.Maui.App.ViewModels;
using Fsv.Maui.App.Views;
using Microsoft.Extensions.Logging;

namespace Fsv.Maui.App
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

            builder.Services.AddScoped<IVerificationsService, VerificationsStubService>();
            builder.Services.AddSingleton<VerificationsListViewModel>();
            builder.Services.AddSingleton<VerificationsList>(serviceProvider => new VerificationsList()
            {
                BindingContext = serviceProvider.GetService<VerificationsListViewModel>()
            });


            return builder.Build();
        }
    }
}
