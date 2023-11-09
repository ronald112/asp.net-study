using Core;

var builder = WebApplication.CreateBuilder(args); // setting up a basic feature, login, configuuration etc..

builder.Services.Configure<FruitOptions>(options =>
{
    options.Name = "Watermelon";
    options.Color = "Green";
});

var app = builder.Build(); // set up middleware components

((IApplicationBuilder)app).Map("/branch", branch =>
{
    branch.Run(new Middleware().Invoke);
}); // /branch/?custom=true

app.UseMiddleware<FruitMiddleware>(); // /fruit

app.MapGet("/", () => "Hello World!");

app.Run();
