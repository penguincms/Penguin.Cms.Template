using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Penguin.Cms.Web.Mvc;
using System;

namespace Penguin.Cms.Client
{
    public static class Program
    {
        public static DateTime BootTime { get; set; } = DateTime.Now;

        public static void Main()
        {
            Penguin.Cms.Web.Mvc.HostBuilder.Configure().ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseIIS()
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