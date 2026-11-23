namespace exNavigationPage;

public partial class SegundaPage : ContentPage
{
    bool corrigido = false;

    public SegundaPage()
    {
        InitializeComponent();
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        if (!corrigido)
        {
            
            alt2.BackgroundColor = Colors.Green;

         
            alt1.BackgroundColor = Colors.Red;
            alt3.BackgroundColor = Colors.Red;
            alt4.BackgroundColor = Colors.Red;

            corrigido = true;

            return;
        }

      
        await Navigation.PushAsync(new TerceiraPage());
    }
}
