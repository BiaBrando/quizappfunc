namespace exNavigationPage;

public partial class OitavaPage : ContentPage
{
    private bool corrigido;

    public OitavaPage()
    {
        InitializeComponent(); NavigationPage.SetHasBackButton(this, false);
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        if (!corrigido)
        {
            if (alt1.IsChecked)
            {
                Pontuacao.Adicionar(1);
            }

            alt1.BackgroundColor = Colors.Green;
            alt2.BackgroundColor = Colors.Red;
            alt3.BackgroundColor = Colors.Red;
            alt4.BackgroundColor = Colors.Red;
            alt5.BackgroundColor = Colors.Red;

            corrigido = true;
            return;
        }

        await Navigation.PushAsync(new NonaPage());
    }
}
