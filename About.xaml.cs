namespace AdrenalistApp;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
        string version = typeof(App).Assembly.GetName().Version.ToString();
        lblVersion.Text = "Version " + version;
    }
}