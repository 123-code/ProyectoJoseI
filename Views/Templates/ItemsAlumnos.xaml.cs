namespace ProyectoJoseI.Views.Templates;

public partial class ItemsAlumnos : ContentView
{
	private readonly AlumnosViewModels viewmodel;
	public ItemsAlumnos()
	{
		try
		{

		

		viewmodel = App.Current.Services.GetService<AlumnosViewModels>();
            InitializeComponent();
         

        }
        catch (Exception ex)
        {

            throw ex;
        }
        
	}
}