using Microsoft.EntityFrameworkCore;
using Shop.Infrastructure.Context;
using Shop.Application.Modules;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//var configurarion = builder.Configuration.GetConnectionString("ShopConnect");
//builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(configurarion));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ShopDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("BookingHotel")));
builder.Services.AddApplicationModule();
//AddCors
builder.Services.AddCors(x => x.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
}
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
