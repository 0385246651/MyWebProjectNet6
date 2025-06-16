using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

public class MyStartUp
{
  // Dùng để đăng ký những dịch vụ (dùng DI)
  public void ConfigureServices(IServiceCollection service)
  {

  }

  //Xấy dựng pipeLine (chuỗi Middleware)
  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    //Truy cập vào file tĩnh 
    // StaticMiddleWare
    // phải để ở đầu. Vì nếu ko nó có thể bị xử lý bởi các request khác
    app.UseStaticFiles();

    //EndpointRoutingMiddleware
    app.UseRouting();

    app.UseEndpoints(endpoints =>

    //dùng npm để quản lý thư viện css và js
    // npm node 

    {
      endpoints.MapGet("/", async (context) =>
      {
        await context.Response.WriteAsync("Trang chu");
      });

      endpoints.MapGet("/about", async (context) =>
      {
        await context.Response.WriteAsync("Gioi thieu");
      });

      endpoints.MapGet("/about", async (context) =>
      {
        await context.Response.WriteAsync("Gioi thieu");
      });

    });

    //Terminal Middleware
    // chạy từ trên xuống dưới xem url nào match
    app.Map("/abc", (app1) =>
    {
      app1.Run(async (HttpContext context) =>
      {
        await context.Response.WriteAsync("Nội dung trả về từ ABC!");
      });
    });

    //Terminal Middleware - Cuối 
    // ít khi dùng thg này 
    // app.Run(async (HttpContext context) =>
    // {
    //   await context.Response.WriteAsync("Xin chào đây là My Start up!");
    // });

    // dùn 1 middleware có sẵn trong asp .net core
    //StatusCodePage
    app.UseStatusCodePages();
  }
}