using AppMauiGalery.Views;

namespace AppMauiGalery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppFlyout();
        }
    }
}
