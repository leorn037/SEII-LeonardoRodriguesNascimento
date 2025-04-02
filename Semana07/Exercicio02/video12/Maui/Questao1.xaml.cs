namespace AppMaui.Paginas;

public partial class QUestao1 : ContentPage
{
    public QUestao1()
    {
        InitializeComponet();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        SecureStorage.Default.GetAsync("nome").ToString();
        LBLTeste.Text = nome;

    }
}