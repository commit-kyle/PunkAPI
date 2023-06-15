using Microsoft.AspNetCore.Mvc;

namespace PunkApiWrapper.Controllers;
[ApiController]
[Route("/search")]
public class SearchCOntroller : ControllerBase {
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task<IActionResult> searchBeer(string query) {
        var response = await _httpClient.GetStringAsync($"https://api.punkapi.com/v2/beers?beer_name={query}");
        return Ok(response);
    }
}