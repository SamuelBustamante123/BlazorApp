using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static string _address = "https://api.sportsdata.io/v3/nba/stats/json/PlayerSeasonStats/2021";
        private string key = "b5c072b0c0084b48976bce47e70e9757";
        private string header = "Ocp-Apim-Subscription-Key";

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<PlayerStats>> Get()
        {
            List<PlayerStats> ?result = await GetResponse();
            return result;
        }

        private async Task<List<PlayerStats>> GetResponse()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, _address);
            request.Headers.Add(header, key);
            var response = await client.SendAsync(request);
            using var responseStream = await response.Content.ReadAsStreamAsync();

            List<PlayerStats> ?result = await JsonSerializer.DeserializeAsync<List<PlayerStats>>(responseStream);
            return result;
        }
    }
}
