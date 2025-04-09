using Xamarin.Essentials;
namespace AdrenalistApp;

public partial class PlaceKajang : ContentPage
{
	public PlaceKajang()
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
        string url = "https://www.google.com/maps/search/?api=1&query=Converse%20Kajang%20Skatepark";

        // Use the Launcher class from Xamarin.Essentials to open the URL
        await Xamarin.Essentials.Launcher.OpenAsync(url);
    }
}