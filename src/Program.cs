var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Console.WriteLine($"The configuration value is {app.Configuration["test"]}");

app.Urls.Add("http://*:3000");
app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => app.Configuration["test"]);

app.Run();
