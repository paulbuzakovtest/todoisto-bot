using Microsoft.Extensions.Hosting;


namespace TodoistoBot.App;

public static class Program
{
    private static Task Main(string[] args) => new HostBuilder()
        .ConfigureServices((context, services) =>
        {
        })
        .RunConsoleAsync();
}