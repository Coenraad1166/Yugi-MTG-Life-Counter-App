using LifeCounter_App.MVVM.Views;

namespace LifeCounter_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SelectGamePage();
        }
    }
}