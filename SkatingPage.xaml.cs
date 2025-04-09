namespace AdrenalistApp;

public partial class SkatingPage : ContentPage
{
	public SkatingPage()
	{
		InitializeComponent();
	}
    private async void SkatingPlace(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SkatingPlace());
    }
}