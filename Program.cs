using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyWebProjectNet5
{
    public class Program
    {
        /* 
            Host (IHost) object :
                - Dependency Injection (ID) : IServiceProvider (ServiceCollection)
                - Logging (ILogging)
                - Configuration
                - IHostedService => StartAsync : Run HTTP Server (Kestrel Http)

                1. Tại IHostBuilder
                2. Cấu hình, đăng ký các dịch vụ (gọi ConfigureWebHostDefaults)
                3. Gọi IHostBuilder.Build() => Host (IHost)
                4. Gọi phương thức Host.Run

                Request => pipeLine (Middleware)
        */

        //Tự tạo
        public static void Main(string[] args)
        {
            Console.WriteLine("Start Appp");
            IHostBuilder builder = Host.CreateDefaultBuilder(args);
            //Khởi tạod đối tg có sẵn dịch vụ 
            builder.ConfigureAppConfiguration((IWebHostBuilder webBuilder) =>
            {
                //Tùy biến thêm về Host
                webBuilder.UseStartup<MyStartUp>();
            });

            IHost host = builder.Build();
            host.Run();
        }


        // public static void Main(string[] args)
        // {
        //     CreateHostBuilder(args).Build().Run();
        // }

        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>();
        //         });
    }
}
