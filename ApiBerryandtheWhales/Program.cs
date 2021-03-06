using ApiBerryandtheWhales.GenericRepo;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiBerryandtheWhales
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            SyncfusionLicenseProvider.RegisterLicense("NDM5ODE3QDMxMzkyZTMxMmUzMFdCVnhrQjUwUVNoYXRyQmNHRjNHZURlY2gzSXUvVkVLSzN1MzE0ZzByVnc9");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();

            builder.Services.AddScoped<IGenericRepository, GenericRepository>();

            await builder.Build().RunAsync();
        }
    }
}
