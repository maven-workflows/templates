using Microsoft.AspNetCore.Mvc.Testing;
using System.Text.Json;
using WebApi.Controllers;

namespace WebApi.Tests.Controllers;

public class WeatherControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private readonly HttpClient _client;

    public WeatherControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _client = _factory.CreateClient();
    }

    [Fact]
    public async Task Get_ReturnsWeatherForecast()
    {
        // Act
        var response = await _client.GetAsync("/api/weather");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var forecasts = JsonSerializer.Deserialize<WeatherForecast[]>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        Assert.NotNull(forecasts);
        Assert.Equal(5, forecasts.Length);
        Assert.All(forecasts, forecast =>
        {
            Assert.NotEqual(default, forecast.Date);
            Assert.NotNull(forecast.Summary);
        });
    }
}
