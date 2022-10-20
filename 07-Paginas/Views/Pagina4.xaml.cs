using Entidades;

namespace _07_Paginas.Views;

public partial class Pagina4 : ContentPage
{

    public Pagina4(clsPersona clsPersona)
	{
		InitializeComponent();
        label1.Text = clsPersona.Nombre +" " +clsPersona.apellido;
    }

   
}