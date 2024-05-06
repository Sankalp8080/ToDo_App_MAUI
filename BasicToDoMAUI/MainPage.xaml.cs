namespace BasicToDoMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            loginFrame.IsVisible = false;
            signupFrame.IsVisible = true;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            signupFrame.IsVisible = false;
            loginFrame.IsVisible = true;
        }
    }

}
