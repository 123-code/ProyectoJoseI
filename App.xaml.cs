using ProyectoJoseI.Services;

namespace ProyectoJoseI;

public partial class App : Application
{
    public new static App Current => (App)Application.Current;

    public IServiceProvider Services { get; }
    public App()
    {
        var services = new ServiceCollection();

        Services = ConfigureServices(services);

        InitializeComponent();

        MainPage = new AppShell();
    }

    private static IServiceProvider ConfigureServices(ServiceCollection services)
    {
        services.AddTransient<IAlumnos, AlumnosServices>();


        services.AddTransient<AlumnosViewModels>();
        services.AddTransient<AlumnoViewModels>();


        services.AddSingleton<ListadoAlumnos>();
        services.AddSingleton<Alumno>();

        services.AddTransient<IAlumnos, AlumnosServices>();
        services.AddTransient<IDialogService, DialogService>();


        return services.BuildServiceProvider();
    }
}
