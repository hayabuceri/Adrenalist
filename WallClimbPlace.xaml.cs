namespace AdrenalistApp;

public partial class WallClimbPlace : ContentPage
{
	public WallClimbPlace()
	{
		InitializeComponent();
	}
    private async void PlaceCamp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceCamp());
    }
    private async void PlaceSgwang(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceSgwang());
    }
    private async void PlaceShahalam(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaceShahalam());
    }
}