namespace AdrenalistApp;

public partial class ActivityPage : ContentPage
{
	public ActivityPage()
	{
		InitializeComponent();
	}
    private async void HikingPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HikingPage());
    }
    private async void SkatingPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SkatingPage());
    }
    private async void WallClimbPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WallClimbPage());
    }
}