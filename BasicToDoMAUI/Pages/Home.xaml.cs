namespace BasicToDoMAUI.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CreateTask());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SettingPage());
    }
}