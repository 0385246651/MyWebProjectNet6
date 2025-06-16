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
      string html = @"
                <!DOCTYPE html>
                  <html>
                    <head>
                        <meta charset=""UTF-8"">
                        <title>Trang web đầu tiên</title>
                        <link rel=""stylesheet"" href=""/css/bootstrap.min.css"" />
                        <script src=""/js/jquery.min.js""></script>
                        <script src=""/js/popper.min.js""></script>
                        <script src=""/js/bootstrap.min.js""></script>


                    </head>
                    <body>
                        <nav class=""navbar navbar-expand-lg navbar-dark bg-danger"">
                                <a class=""navbar-brand"" href=""#"">Brand-Logo</a>
                                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#my-nav-bar"" aria-controls=""my-nav-bar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                                        <span class=""navbar-toggler-icon""></span>
                                </button>
                                <div class=""collapse navbar-collapse"" id=""my-nav-bar"">
                                <ul class=""navbar-nav"">
                                    <li class=""nav-item active"">
                                        <a class=""nav-link"" href=""#"">Trang chủ</a>
                                    </li>
                                
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""#"">Học HTML</a>
                                    </li>
                                
                                    <li class=""nav-item"">
                                        <a class=""nav-link disabled"" href=""#"">Gửi bài</a>
                                    </li>
                            </ul>
                            </div>
                        </nav> 
                        <p class=""display-4 text-danger"">Đây là trang đã có Bootstrap</p>
                    </body>
                  </html>
                ";
      await context.Response.WriteAsync(html);
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