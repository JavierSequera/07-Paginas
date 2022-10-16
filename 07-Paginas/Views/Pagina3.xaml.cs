namespace _07_Paginas.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}