namespace exNavigationPage;

public partial class TerceiraPage : ContentPage
{
    private bool corrigido;

    public TerceiraPage()
    {
        InitializeComponent();
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        if (!corrigido)
        {
            if (alt2.IsChecked)
            {
                Pontuacao.Adicionar(1);
            }

            alt1.BackgroundColor = Colors.Red;
            alt2.BackgroundColor = Colors.Green;
            alt3.BackgroundColor = Colors.Red;
            alt4.BackgroundColor = Colors.Red;

            corrigido = true;
            return;
        }

        await Navigation.PushAsync(new QuartaPage());
    }
}
