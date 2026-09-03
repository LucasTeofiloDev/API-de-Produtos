using ApiDeProdutos.Model.Context;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using ApiDeProdutos.Services.Interfaces;
using ApiDeProdutos.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MSSQLContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IProductServices, ProductServicesImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
