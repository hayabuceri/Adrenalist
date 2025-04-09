namespace AdrenalistApp;

public partial class RatePlace : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
    public RatePlace()
	{
		InitializeComponent();
	}
    async void SaveButton(object sender, EventArgs e)
    {

        string? Rating = rating.SelectedItem?.ToString();
        string? Comment = comment.Text;
        string? Place = place.SelectedItem?.ToString();
        await firebaseHelper.AddRecord(Rating, Comment, Place);
        await DisplayAlert("Rating Saved","Rating has been saved!","OK");

    }
    private async void PlaceKinabalu(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void PlaceStong(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}