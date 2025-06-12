using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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

    //Terminal Middleware
    app.RUn();
  }
}