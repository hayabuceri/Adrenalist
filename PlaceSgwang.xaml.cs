namespace AdrenalistApp;

public partial class PlaceSgwang : ContentPage
{
	public PlaceSgwang()
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
        string url = "https://www.google.com/maps/search/?api=1&query=Beastpark%20Sungei%20Wang";

        // Use the Launcher class from Xamarin.Essentials to open the URL
        await Xamarin.Essentials.Launcher.OpenAsync(url);
    }
}