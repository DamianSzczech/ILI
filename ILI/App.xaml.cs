using ILI.Database;
using System.Windows;

namespace ILI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DatabaseSeeder.Seed();
        }
    }

}
