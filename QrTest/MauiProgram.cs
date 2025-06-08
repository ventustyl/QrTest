using Microsoft.Extensions.Logging;
using ZXing.Net.Maui;          // Extension UseBarcodeReader()
using ZXing.Net.Maui.Controls; // Ajout de l'espace de noms requis
using QrTest.Pages;
using QrTest.Services;
using QrTest.ViewModels;

namespace QrTest
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                // Démarrage de l’application MAUI
                .UseMauiApp<App>()

                // Initialisation du moteur caméra + lecture de codes‐barres/QR (ZXing)
                .UseBarcodeReader() // Assurez-vous que ZXing.Net.Maui est correctement référencé

                // Police(s) personnalisée(s)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Hébergeur Blazor dans le WebView
            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddSingleton<IApplicationService, ApplicationService>();
            builder.Services.AddTransient<ScanViewModel>();
            builder.Services.AddTransient<ScanPage>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}