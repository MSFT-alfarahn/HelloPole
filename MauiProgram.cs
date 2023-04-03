global using HelloPole.ViewModel;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
global using HelloPole.View;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using HelloPole.Model;


#if ANDROID
using HelloPole.Platforms.Android;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#elif WINDOWS
using HelloPole.Platforms.Windows;
#endif

namespace HelloPole;

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

		builder.Services.AddSingleton<INotificationService, NotificationService>();

		builder.Services.AddSingleton<LoginViewModel>();
		builder.Services.AddSingleton<LoginPage>();	

		builder.Services.AddSingleton<HomeViewModel>();
		builder.Services.AddSingleton<HomePage>();

		return builder.Build();
	}
}
