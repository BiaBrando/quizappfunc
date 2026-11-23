namespace exNavigationPage;

public partial class DecimaPrimeiraPage : ContentPage
{
    private bool corrigido;

    public DecimaPrimeiraPage()
    {
        InitializeComponent();
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        if (!corrigido)
        {
            if (alt4.IsChecked)
            {
                Pontuacao.Adicionar(1);
            }

            alt1.BackgroundColor = Colors.Red;
            alt2.BackgroundColor = Colors.Red;
            alt3.BackgroundColor = Colors.Red;
            alt4.BackgroundColor = Colors.Green;
            alt5.BackgroundColor = Colors.Red;

            corrigido = true;
            return;
        }

        await DisplayAlert("Quiz concluído", $"Sua pontuação: {Pontuacao.total}/10", "OK");
    }
}
