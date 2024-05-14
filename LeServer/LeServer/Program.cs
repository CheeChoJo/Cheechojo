using System;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

class Program
{
    static async Task<int> GetWebsiteResponseCode(string url)
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
                return -1; 
            }
        }
    }

    static async Task<double> GetBakalariValAsync()
    {
        var responseCode = await GetWebsiteResponseCode("https://gateway.gymvod.cz:444/next/rozvrh.aspx");
        double bakalariVal = 80.0 / (responseCode);
        return bakalariVal;
    }

    static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", async (HttpContext http) =>
        {
            double bakalariVal = await GetBakalariValAsync();
            return bakalariVal;
        });

        await app.RunAsync();
    }
}
