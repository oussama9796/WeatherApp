using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private static HttpClient _httpClient;

        static WeatherForecastController() 
        {
            _httpClient = new HttpClient();
        }
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get(string cityname)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid=b8b792ee3e47593ddd0fb29069d2aade";
            var response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
            

        }
    }
}