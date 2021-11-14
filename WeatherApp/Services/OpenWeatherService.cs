using System;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;
using WeatherApp.ViewModels;

namespace OpenWeatherAPI
{
    public class OpenWeatherService : IWindDataService
    {
        private OpenWeatherProcessor owp;
        public WindDataModel LastWindData = new WindDataModel();

        public OpenWeatherService(string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;
        }

        public async Task<WindDataModel> GetDataAsync()
        {
            Task<OWCurrentWeaterModel> task = owp.GetCurrentWeatherAsync();
            LastWindData = new WindDataModel { DateTime = DateTime.UnixEpoch.AddSeconds(task.Result.DateTime), Direction = task.Result.Wind.Deg, MetrePerSec = task.Result.Wind.Speed };
            await task;
            return LastWindData; 
        }
    }
}
