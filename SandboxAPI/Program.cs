using Microsoft.AspNetCore.Builder;
using SayHelloCPP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return "Hello";
});


app.MapGet("/cpp", () =>
{
    var hello = new SayHello();
    return hello.Say();
});

app.Run();

