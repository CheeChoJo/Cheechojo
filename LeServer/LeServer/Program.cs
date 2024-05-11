using System.Net.Http;

async Task<int> GetWebsiteResponseCode(string url)
{
    using (var client = new HttpClient())
    {
        try
        {
            var response = await client.GetAsync(url);
            return (int)response.StatusCode;
        }
        catch (HttpRequestException)
        {
            // Handle exceptions (e.g., connection errors)
            return -1; // Or another value to indicate an error
        }
    }
}
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


async Task<double> GetBakalariValAsync()
{
    double bakalariVal = 8.0 / await GetWebsiteResponseCode("https://gateway.gymvod.cz:444/login");
    return bakalariVal;
}
app.MapGet("/", () =>
{
    double bakalariVal = GetBakalariValAsync().ConfigureAwait(false).GetAwaiter().GetResult();
    return bakalariVal;
});

app.Run();

