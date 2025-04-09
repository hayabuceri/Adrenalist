namespace AdrenalistApp;

public partial class PlaceStong : ContentPage
{
	public PlaceStong()
	{
		InitializeComponent();
	}
    private async void RatePlace(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RatePlace());
    }
    private async void MapsButton_Clicked(object sender, EventArgs e)
    {
        // Construct the URL to open in the device's default browser
        string url = "https://www.google.com/maps/search/?api=1&query=Gunung%20Stong";

        // Use the Launcher class from Xamarin.Essentials to open the URL
        await Xamarin.Essentials.Launcher.OpenAsync(url);
    }
}