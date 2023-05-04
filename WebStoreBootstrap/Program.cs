using Microsoft.AspNetCore.Builder;
using WebStoreBootstrap.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvcCore(options => options.EnableEndpointRouting = false);

builder.Services.AddSingleton<IWorker, IWorkerRepository>();
//builder.Services.AddControllers(options => options.EnableEndpointRouting = false);


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

//IR A PÁGINA DESADA
//DefaultFilesOptions d = new DefaultFilesOptions();
//d.DefaultFileNames.Clear();
//d.DefaultFileNames.Add("noDefault.html");
//app.UseDefaultFiles(d);

//app.UseMvc(routes =>
//{
//    routes.MapRoute(
//    name: "default",
//    template: "{controller=FooController}/{action=Index}/{id?}");
//});
//app.MapControllerRoute(
//           "Default", // Route name
//           "",        // URL with parameters
//           new { controller = "Home", action = "Index" }  // Parameter defaults
//       );
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.UseDefaultFiles();


app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();




