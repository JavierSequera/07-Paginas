﻿namespace _07_Paginas;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Views.PaginaTabbed());
	}
}

