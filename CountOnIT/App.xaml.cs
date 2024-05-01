using Microsoft.EntityFrameworkCore;

namespace CountOnIT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            
        }
    }
}
