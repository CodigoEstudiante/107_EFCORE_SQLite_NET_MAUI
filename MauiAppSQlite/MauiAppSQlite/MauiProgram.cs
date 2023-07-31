using Microsoft.Extensions.Logging;
using MauiAppSQlite.DataAccess;

namespace MauiAppSQlite;

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

		builder.Services.AddDbContext<DemoDbContext>();
		builder.Services.AddTransient<MainPage>();

		var dbContext = new DemoDbContext();
		dbContext.Database.EnsureCreated();
		dbContext.Dispose();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
