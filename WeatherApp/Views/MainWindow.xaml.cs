using OpenWeatherAPI;
using System.Windows;
using WeatherApp.Services;
using WeatherApp.ViewModels;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindDataViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            /// TODO : Faire les appels de configuration ici ainsi que l'initialisation
            var apiKey = AppConfiguration.GetValue("OWApiKey");
            ApiHelper.InitializeClient();
            vm = new WindDataViewModel();
            //IWindDataService windDataService = new OpenWeatherService(apiKey);
            DataContext = vm;
        }
    }
}
