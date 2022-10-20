using Entidades;

namespace _07_Paginas;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private clsPersona crearNino()
	{
		clsPersona persona = new clsPersona();
		persona.Nombre = entryNombre.Text;
		persona.apellido = entryApellido.Text;
		
		return persona;
	}
	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new Views.PaginaTabbed());
	}
    private async void NavegarPag4(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.Pagina4(crearNino()));
    }
    private async void NavegarPag5(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Views.Pagina5 {BindingContext = crearNino()});
    }
}

