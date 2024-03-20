using NLog.Web;
using EmployeeManagement;
using EmployeeManagement.Entities;

var builder = WebApplication.CreateBuilder(args);

// NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
builder.Host.UseNLog();

// Configure service

builder.Services.AddControllers();
builder.Services.AddDbContext<CompanyDbContext>();
builder.Services.AddScoped<CompanySeeder>();

var app = builder.Build();

// Configure the HTTP request pipeline

var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<CompanySeeder>();

seeder.Seed();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
