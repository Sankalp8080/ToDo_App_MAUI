using BasicToDoMAUI.Pages;

namespace BasicToDoMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             MainPage = new UserProfile();
          
        }
    }
}
