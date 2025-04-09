namespace AdrenalistApp;

public partial class Record : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
    public Record()
	{
		InitializeComponent();
	}
	protected async override void OnAppearing()
    {
     base.OnAppearing();
     displayRecord.ItemsSource = await firebaseHelper.GetAllAdrenalistApp();
     displayRecord2.ItemsSource = await firebaseHelper.GetAllAdrenalistApp2();
     displayRecord3.ItemsSource = await firebaseHelper.GetAllAdrenalistApp3();
    }

    private async Task DeleteAdrenalistRecord(string key)
    {
        await firebaseHelper
        .DeleteAdrenalistRecord(key);
        displayRecord.ItemsSource = await firebaseHelper.GetAllAdrenalistApp();
    }
}