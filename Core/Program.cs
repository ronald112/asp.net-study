var builder = WebApplication.CreateBuilder(args); // setting up a basic feature, login, configuuration etc..

var app = builder.Build(); // set up middleware components

app.MapGet("/", () => "Hello World!");

app.Run();
