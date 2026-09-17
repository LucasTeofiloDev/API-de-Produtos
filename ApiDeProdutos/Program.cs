using ApiDeProdutos.Services.Interfaces;
using ApiDeProdutos.Services.Implementations;
using ApiDeProdutos.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDatabaseConfig(builder.Configuration);

builder.Services.AddScoped<IProductServices, ProductServicesImpl>();

builder.Host.AddSerilogConfig(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
