namespace AdrenalistApp;

public partial class PlaceShahalam : ContentPage
{
	public PlaceShahalam()
	{
		InitializeComponent();
	}
    private async void RateWallclimb(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RateWallclimb());
    }
    private async void MapsButton_Clicked(object sender, EventArgs e)
    {
        // Construct the URL to open in the device's default browser
        string url = "https://www.google.com/maps/search/?api=1&query=Rocky%20Basecamp%20Shah%20Alam";

        // Use the Launcher class from Xamarin.Essentials to open the URL
        await Xamarin.Essentials.Launcher.OpenAsync(url);
    }
}