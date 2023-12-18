using ProyectoJoseI.ViewModels;
using ProyectoJoseI.Views;
using Microsoft.Extensions.DependencyInjection;
using ProyectoJoseI.Interfaces;
using ProyectoJoseI.Services;

namespace ProyectoJoseI;

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
			string dbPath = FileAccessHelper.GetPathFile("alumnos.db3");

		return builder.Build();
	}
}
