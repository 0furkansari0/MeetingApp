
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //For mvc pattern

var app = builder.Build();

//wwwroot içindeki static dosyalar
app.UseStaticFiles();

/* //wwwroot dışında başka bir path deki static dosyaları kullanmak için
using Microsoft.Extensions.FileProviders;
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
    RequestPath = "/StaticFiles"
});*/


app.UseRouting();

//mvc
//rest api
//razor pages

// {controller = home}/{action = index}/id?
//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);



app.Run();
