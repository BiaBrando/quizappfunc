namespace exNavigationPage;

public partial class DecimaPage : ContentPage
{
    private bool corrigido;

    public DecimaPage()
    {
        InitializeComponent();
         NavigationPage.SetHasBackButton(this, false);
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        if (!corrigido)
        {
            if (alt5.IsChecked)
            {
                Pontuacao.Adicionar(1);
            }

            alt1.BackgroundColor = Colors.Red;
            alt2.BackgroundColor = Colors.Red;
            alt3.BackgroundColor = Colors.Red;
            alt4.BackgroundColor = Colors.Red;
            alt5.BackgroundColor = Colors.Green;

            corrigido = true;
            return;
        }

        await Navigation.PushAsync(new DecimaPrimeiraPage());
    }
}
