using Javax.Security.Auth;

namespace AppMaui.Paginas;

public partial class Questao1 : ContentPage
{
    bool marcou = false;
    bool acertou = false;

    public Questao1()
    {
        InitializeComponet();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        SecureStorage.Default.GetAsync("nome").ToString();
        LBLTeste.Text = nome;

    }
    private void verificar(object sender, EventArgs e)
    {
        if(marcou)
        {
            marcou= false;
        }
        else
        {
            RadioButton opcao = sender as RadioButton;

            string valoropcao = opcao.Value.ToString();

            if(valoropcao.Contains("certo"))
            {
                acertou = true;

            }
            else 
            ´{
                acertou = false;
        
            }
            marcou = true;

        }
        private void BTNVerificar_Clicked(object sender, EventArgs e)
        {
            if{

            DisplayAlert("Resultado","Você acertou!","Ok")
            
            }
            else{

            DisplayAlert("Resultado","Você Errou","Ok")
            
            }
        }

    }
}