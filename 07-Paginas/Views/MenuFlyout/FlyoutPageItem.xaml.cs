namespace _07_Paginas.Views.MenuFlyout;

public partial class FlyoutPageItem : ContentPage
{
	public FlyoutPageItem()
	{
		InitializeComponent();
	}

    public string Title { get; set; }
    public string IconSource { get; set; }
    public Type TargetType { get; set; }
}