using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(DotnetFlix.Areas.Identity.IdentityHostingStartup))]
namespace DotnetFlix.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}