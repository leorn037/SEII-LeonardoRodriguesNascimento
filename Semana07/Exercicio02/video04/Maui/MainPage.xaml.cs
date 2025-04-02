public partial class MainPage : ContentPage
{
	string nome;
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void BTNOla_Clicked(object sender, EventArgs e)
	{
		nome = await DisplayAlert("Nome","Digite seu nome","Ok");
		await DisplayAlert("Aviso","Olá" + nome, "Ok");
	}
}
