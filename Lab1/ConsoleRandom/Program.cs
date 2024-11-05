using ConsoleRandom.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// See https://aka.ms/new-console-template for more information
var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddTransient<IRandomService, RandomService>();
builder.Services.AddTransient<ICalculationService, CalculationService>();
builder.Services.AddTransient<ConsoleRandom.Runner>();
var host = builder.Build();
var rand = host.Services.GetRequiredService<IRandomService>();

// Console.WriteLine($"My rand number is {rand.GetRandom()}");
var runner = host.Services.GetRequiredService<ConsoleRandom.Runner>();
runner.Run();
