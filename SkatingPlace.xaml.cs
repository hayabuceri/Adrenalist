namespace AdrenalistApp;

public partial class SkatingPlace : ContentPage
{
	public SkatingPlace()
	{
		InitializeComponent();
	}
    private async void PlacePutrajaya(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlacePutrajaya());
    }
    private async void PlaceKajang(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceKajang());
    }
    private async void PlaceKiara(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceKiara());
    }

}