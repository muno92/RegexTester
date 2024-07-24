using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly:CLSCompliant(false)]
namespace RegexTester;

public static class Program
{
    private static int unused = 1;
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");

        builder.Services.AddScoped(
            _ => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

        await builder.Build().RunAsync().ConfigureAwait(false);
    }
}
