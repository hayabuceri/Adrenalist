namespace AdrenalistApp;

public partial class RateWallclimb : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
    public RateWallclimb()
    {
        InitializeComponent();
    }
    async void SaveButton3(object sender, EventArgs e)
    {

        string? Rating3 = rating3.SelectedItem?.ToString();
        string? Comment3 = comment3.Text;
        string? Place3 = place3.SelectedItem?.ToString();
        await firebaseHelper.AddRecord3(Rating3, Comment3, Place3);
        await DisplayAlert("Rating Saved", "Rating has been saved!", "OK");

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