using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace backoffice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .UseKestrel()
                    .UseUrls("https://*:5001", "http://*:5000");
                });
    }
}
