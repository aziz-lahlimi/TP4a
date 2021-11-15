using OpenWeatherAPI;
using System;
using System.Threading.Tasks;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {
        private OpenWeatherProcessor _sut;
        //Afficher le message de l’exception dans l’erreur que ApiKey est vide ou null.
        [Fact]
        public async void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            _sut = OpenWeatherProcessor.Instance;
            _sut.ApiKey = "balabla";
            ApiHelper.ApiClient = null;
            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetOneCallAsync());

        }
        //Afficher le message de l’exception dans l’erreur que ApiKey est vide ou null.
        [Fact]
        public async void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            _sut = OpenWeatherProcessor.Instance;
            _sut.ApiKey = "balabla";
            ApiHelper.ApiClient = null;
            await Assert.ThrowsAsync<ArgumentException>(() => _sut.GetCurrentWeatherAsync());
        }
       
    }
}
