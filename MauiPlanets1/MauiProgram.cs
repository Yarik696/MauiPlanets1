using Microsoft.Extensions.Logging;

namespace MauiPlanets1
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
                    //otsida Internetist need fontid ülesse ja panna enda projekti
                    fonts.AddFont("ffonts.net.html", "ffonts.net.txt");
                    fonts.AddFont("GlazeCaps2002.ttf", "quick_tips.html");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
