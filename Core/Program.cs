using Core;

var builder = WebApplication.CreateBuilder(args); // setting up a basic feature, login, configuuration etc..

builder.Services.Configure<FruitOptions>(options =>
{

});

var app = builder.Build(); // set up middleware components

//app.Use(async (context, next) =>
//{
//    if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "")
//    {
//        context.Response.ContentType = "text/plain";
//        await context.Response.WriteAsync("Custom Middleware\n");
//    }
//    await next.Invoke();
//    //await next(); // same as await next.Invoke();
//});

((IApplicationBuilder)app).Map("/branch", branch =>
{
    branch.Run(new Middleware().Invoke);
});

app.UseMiddleware<Middleware>();

app.MapGet("/", () => "Hello World!");

app.Run();
