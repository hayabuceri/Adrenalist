namespace AdrenalistApp;

public partial class HikingPlace : ContentPage
{
	public HikingPlace()
	{
		InitializeComponent();
	}
    private async void PlaceKinabalu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceKinabalu());
    }
    private async void PlaceStong(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceStong());
    }
    private async void PlaceTahan(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceTahan());
    }

}