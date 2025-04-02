namespace Maui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void BTNOla_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Aviso","Olá mundo!","Ok");
	}
}

