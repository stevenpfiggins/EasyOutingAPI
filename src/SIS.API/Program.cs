﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace RedStarter.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseSetting("detailedErrors", "true")
                .UseStartup<Startup>()
                .CaptureStartupErrors(true);
    }
}
