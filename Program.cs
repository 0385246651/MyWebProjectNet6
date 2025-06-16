using Microsoft.AspNetCore.Hosting; // Cần thiết cho IWebHostBuilder, ConfigureWebHostDefaults
using Microsoft.Extensions.Hosting; // Cần thiết cho IHostBuilder, Host
using System; // Cần thiết cho Console.WriteLine

namespace MyWebProjectNet5
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Starting the application..."); // Thông báo khởi động rõ ràng
            // Gọi phương thức CreateHostBuilder để xây dựng và chạy Host
            CreateHostBuilder(args).Build().Run();
        }

        // Đây là phương thức chuẩn để tạo và cấu hình IHostBuilder cho ứng dụng web ASP.NET Core
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args) // Bắt đầu với một Host Builder mặc định
                .ConfigureWebHostDefaults(webBuilder => // Cấu hình các thiết lập đặc thù cho Web Host
                {
                    // Tại đây, bạn chỉ định lớp Startup của ứng dụng web
                    // Đảm bảo bạn có một class MyStartUp với các phương thức ConfigureServices và Configure
                    webBuilder.UseWebRoot("public");
                    webBuilder.UseStartup<MyStartUp>();
                });
    }
}