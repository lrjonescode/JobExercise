using EagleRock.Repository;
using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Services;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBotStatusService, BotStatusService>();
builder.Services.AddSingleton<ITrafficSegmentRepository, TrafficSegmentRepository>();
//builder.Services.AddDbContext<TrafficSegmentContext>(options => options.UseMemoryCache()
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
