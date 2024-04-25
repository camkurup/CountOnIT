using Microsoft.EntityFrameworkCore;
using static Android.Graphics.ImageDecoder;

namespace CountOnIT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            
        }

        private void ConfigureServices()
        {
            var services = new ServiceCollection();

            // Tilføj DbContext til tjenester
            services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer("Data Source = CKU - PC; Initial Catalog = CountOnIT; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False"));

            // Opret ServiceProvider
            var serviceProvider = services.BuildServiceProvider();

            // Hent DbContext fra ServiceProvider
            var dbContext = serviceProvider.GetRequiredService<MyDbContext>();

            // Nu kan du bruge dbContext til at interagere med din database
        }
    }
}
