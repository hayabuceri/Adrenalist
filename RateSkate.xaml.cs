namespace AdrenalistApp;

public partial class RateSkate : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
    public RateSkate()
    {
        InitializeComponent();
    }
    async void SaveButton2(object sender, EventArgs e)
    {

        string? Rating2 = rating2.SelectedItem?.ToString();
        string? Comment2 = comment2.Text;
        string? Place2 = place2.SelectedItem?.ToString();
        await firebaseHelper.AddRecord2(Rating2, Comment2, Place2);
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