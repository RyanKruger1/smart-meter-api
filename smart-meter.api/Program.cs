using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using smart_meter.application.Service;
using smart_meter.domain.Interfaces;
using smart_meter.domain.Interfaces.Services;
using smart_meter.domain.models.Settings;
using smart_meter.infrasturcture.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers(options =>
{
    options.RespectBrowserAcceptHeader = true;
    options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
});

String connectionString = "";
                        
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

connectionString = builder.Configuration["SQLServer:ConnectionString"];
builder.Services.AddDbContext<ReadingsDbContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("smart-meter.api")));
builder.Services.AddDbContext<SmartMeterDbContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("smart-meter.api")));

builder.Services.AddScoped<ISmartMeterRepository, SmartMeterRepository>();
builder.Services.AddScoped<ISmartMeterService, SmartMeterService>();

builder.Services.AddScoped<IReadingRepository, ReadingRepository>();
builder.Services.AddScoped<IReadingService, ReadingsService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();