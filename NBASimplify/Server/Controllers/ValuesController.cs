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
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<PlayerStats>> Get()
        {
            List<PlayerStats>? result = await GetResponse();
            return result;
        }

        private async Task<List<PlayerStats>> GetResponse()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, SportsDataIoGlobals.Address);
            request.Headers.Add(SportsDataIoGlobals.Header, SportsDataIoGlobals.Key);
            var response = await client.SendAsync(request);
            using var responseStream = await response.Content.ReadAsStreamAsync();

            List<PlayerStats>? result = await JsonSerializer.DeserializeAsync<List<PlayerStats>>(responseStream);
            return result;
        }
    }
}