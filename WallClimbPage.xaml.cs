namespace AdrenalistApp;

public partial class WallClimbPage : ContentPage
{
	public WallClimbPage()
	{
		InitializeComponent();
	}
    private async void WallClimbPlace(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WallClimbPlace());
    }
}