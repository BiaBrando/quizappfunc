namespace exNavigationPage;

public partial class QuartaPage : ContentPage
{
    public QuartaPage()
    {
        InitializeComponent();
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuintaPage());
    }
}
