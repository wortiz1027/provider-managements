using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Steeltoe.Extensions.Configuration.ConfigServer;
using Steeltoe.Extensions.Logging.DynamicSerilog;
using Steeltoe.Discovery.Client;
using Steeltoe.Extensions.Configuration.Placeholder;

namespace Api
{
     public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
            .Build()
            .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var builder = WebHost.CreateDefaultBuilder(args)
                                .UseDefaultServiceProvider(configure => configure.ValidateScopes = false)
                                .AddConfigServer()
                                .AddPlaceholderResolver()
                                .ConfigureLogging((context, builder) => builder.AddSerilogDynamicConsole())
                                .UseStartup<Startup>();
            return builder;
        }
    }
}
