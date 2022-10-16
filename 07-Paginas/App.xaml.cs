namespace _07_Paginas;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.MenuFlyout.FlyoutPageNavigation();
	}
}
