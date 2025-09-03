using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Training_FrontEnd.Models;

public class SchoolController : Controller
{
    private readonly HttpClient _httpClient;
    private readonly ApiSetting _apiSettings;

    public SchoolController(HttpClient httpClient, IOptions<ApiSetting> apiSettings)
    {
        _httpClient = httpClient;
        _apiSettings = apiSettings.Value;
    }

    public async Task<IActionResult> Index()
    {
        var url = $"{_apiSettings.BaseUrl}{_apiSettings.Endpoint}";

        var response = await _httpClient.GetStringAsync(url);

        var result = JsonConvert.DeserializeObject<ApiResponse<List<School>>>(response);

        // نجيب الـ Data فقط
        var schools = result.Data;

        return View(schools);

    }
}

