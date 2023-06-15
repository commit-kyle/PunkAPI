using Microsoft.AspNetCore.Mvc;

namespace PunkApiWrapper.Controllers;
[ApiController]
[Route("/beer")]
public class BeerController : ControllerBase {
    private String Root_URL = "https://api.punkapi.com/v2/beers";
    private readonly HttpClient _httpClient = new HttpClient();

    [HttpGet("menu")]
    public async Task<IActionResult> GetMenu() {
        var response = await _httpClient.GetStringAsync($"{Root_URL}");
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBeer(int id) {
        var response = await _httpClient.GetStringAsync($"{Root_URL}/{id}");
        return Ok(response);
    }

    [HttpGet("random")]
    public async Task<IActionResult> GetRandomBeer() {
        var response = await _httpClient.GetStringAsync($"{Root_URL}/random");
        return Ok(response);
    }
}
