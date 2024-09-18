using BlazorApp.Pages;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;

namespace BlazorApp
{
    public class Program
    {
        static WebAssemblyHost _host;

        static System.Threading.Timer _timer;

        static Program()
        {
            
        }

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.RootComponents.Add<Dashboard>("dash-board");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            _host = builder.Build();
            
            await _host.RunAsync();
        }        
    }
}
