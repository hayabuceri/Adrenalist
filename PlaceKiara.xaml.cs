namespace AdrenalistApp;

public partial class PlaceKiara : ContentPage
{
	public PlaceKiara()
	{
		InitializeComponent();
	}
    private async void RateSkate(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RateSkate());
    }
    private async void MapsButton_Clicked(object sender, EventArgs e)
    {
        // Construct the URL to open in the device's default browser
        string url = "https://www.google.com/maps/search/?api=1&query=Skatepark%20Bukit%20Kiara";

        // Use the Launcher class from Xamarin.Essentials to open the URL
        await Xamarin.Essentials.Launcher.OpenAsync(url);
    }
}