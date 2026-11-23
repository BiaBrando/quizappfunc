namespace exNavigationPage;

public partial class FinalPage : ContentPage
{
    public FinalPage()
    {
        InitializeComponent();
        ResultadoLabel.Text = $"Você acertou {Pontuacao.total} de 10 questões!";
    }

    private async void OnJogarNovamente(object sender, EventArgs e)
    {
        Pontuacao.Zerar();
        await Navigation.PopToRootAsync();
    }
}
