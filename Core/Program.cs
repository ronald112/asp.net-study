using Core.Interfaces;

var builder = WebApplication.CreateBuilder(args); // setting up a basic feature, login, configuuration etc..

var app = builder.Build(); // set up middleware components

IResponceFormater responceFormater = new HttpTextFormatter();

app.MapGet("/formater1", async context =>
{
    await responceFormater.Format(context, "Formatter1");
});

app.MapGet("/formater2", async context =>
{
    await responceFormater.Format(context, "Formatter2");
});

app.MapGet("/", () => "Hello World!");

app.Run();
