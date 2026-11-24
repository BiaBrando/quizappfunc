namespace exNavigationPage;

public partial class SetimaPage : ContentPage
{
    private bool corrigido;

    public SetimaPage()
    {
        InitializeComponent();
         NavigationPage.SetHasBackButton(this, false);
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
            alt5.BackgroundColor = Colors.Red;

            corrigido = true;
            return;
        }

        await Navigation.PushAsync(new OitavaPage());
    }
}
