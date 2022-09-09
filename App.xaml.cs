using MauiApp1;
using MauiAppExtensions;

namespace English.Maui
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            this.AddHelper();
            MainPage = new AppShell();
        }
    }
}