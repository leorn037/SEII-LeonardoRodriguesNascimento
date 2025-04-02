namespace Maui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	protected override void OnAppearing()
    {
        base.OnAppearing();
        SecureStorage.Default.RemoveAll();
        

	private async void BTNIniciar_Clicked(object sender, EventArgs e)
	{
		string pergunta = await DisplayPromptAsync("Pergunta","Qual é o seu nome?","Ok","Cancelar");
		
		await SecureStorage.Default.SetAsync("nome",pergunta);
		await Navigation.PushAsync(new Questao1());

	}
}

