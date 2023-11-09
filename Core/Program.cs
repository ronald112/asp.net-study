using Core;
using Core.Interfaces;
using System.Runtime.Serialization;

var builder = WebApplication.CreateBuilder(args); // setting up a basic feature, login, configuuration etc..

builder.Services.AddSingleton<IResponceFormater, HtmlTextFormater>();

var app = builder.Build(); // set up middleware components

//IResponceFormater responceFormater = new HttpTextFormatter();

app.MapGet("/formater1", async (HttpContext context, IResponceFormater formatter) =>
{
    await formatter.Format(context, "Formatter1");
});

app.MapGet("/formater2", async (HttpContext context, IResponceFormater formatter) =>
{
    await formatter.Format(context, "Formatter2");
});

app.UseMiddleware<CustomMiddleware>();

app.MapGet("/endpoint", CustomEndpoint.Endpoint);

app.MapGet("/", () => "Hello World!");

app.Run();
