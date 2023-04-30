using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace Penguin.Cms.Template
{
    public static class Program
    {
        public static DateTime BootTime { get; set; } = DateTime.Now;

        public static void Main()
        {
            Web.Mvc.HostBuilder.Configure().ConfigureWebHostDefaults(webBuilder =>
            {
                _ = webBuilder.UseIIS()
                .ConfigureKestrel(serverOptions =>
                {
                    // Set properties and call methods on options
                })

                .UseIISIntegration()
                .UseStartup<Startup>();
            })
            .Build().Run();
        }
    }
}