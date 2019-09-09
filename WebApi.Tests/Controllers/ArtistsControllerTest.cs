using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApi.Data.Entities;
using Xunit;

namespace WebApi.Tests.Controllers
{
    public class ArtistsControllerTest : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ArtistsControllerTest(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CanGetArtists()
        {
            // The endpoint or route of the controller action.
            var httpResponse = await _client.GetAsync("/artists");

            // Must be successful.
            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var artists = JsonConvert.DeserializeObject<IEnumerable<Artists>>(stringResponse);
            
            Assert.Equal(2, artists.Count());
            Assert.Contains(artists, p => p.Name =="Foo");
            Assert.Contains(artists, p => p.Name == "Bar");
        }
    }
}