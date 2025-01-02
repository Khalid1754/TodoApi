using ConcertBookingApp.Services;
using ConcertBookingApp.Views;

namespace ConcertBookingApp;

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

        // Register services and pages
        builder.Services.AddSingleton<IConcertService, ConcertService>();
        builder.Services.AddSingleton<IBookingService, BookingService>();

        // Register pages
        builder.Services.AddTransient<ConcertListPage>();
        builder.Services.AddTransient<BookingPage>();

        return builder.Build();
    }
}