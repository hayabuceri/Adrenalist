using Xamarin.Essentials;
namespace AdrenalistApp;

public partial class HikingPage : ContentPage
{
	public HikingPage()
	{
		InitializeComponent();
	}
    private async void HikingPlace(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HikingPlace());
    }
}