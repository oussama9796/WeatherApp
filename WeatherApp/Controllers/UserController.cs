using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using WeatherApp.Controllers;
using WeatherApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherApp.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        HttpClientHandler _httpClient = new HttpClientHandler();
        // GET: api/<UserController>

        public UserController(HttpClient httpClient) 
        {
            _httpClient.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true; 
        }

        [HttpGet("weather")]
        public async Task<string> GetasyncAsync()
        {
            using ( var client = new HttpClient(_httpClient)) 
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Accept.Clear();
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=Casablanca&appid=b8b792ee3e47593ddd0fb29069d2aade");

                using (var response = await client.GetAsync(url)) 
                { 
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(apiResponse);
                    return apiResponse;
                }
            }
               
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
