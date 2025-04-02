public partial class MainPage : TabbedPage
{
	string nome;
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
		string endereco = @"<frane width=\"560\"height=\"315\" src=\"https://www.youtube.com/watch?v=x9jmkLaIiiE&list=PLMna-rY1-pteYXO20ZH4OBce4SJkda1gy&index=7"
		WVVideo.Source =new HtmlWebViewSource
		{
			Html=endereco
		};

	private void BTNOla_Clicked(object sender, EventArgs e)
	{
		nome = await DisplayAlert("Nome","Digite seu nome","Ok");
		await DisplayAlert("Aviso","Olá" + nome, "Ok");
	}
}
