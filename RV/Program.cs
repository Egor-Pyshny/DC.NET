using Microsoft.EntityFrameworkCore;
using RV.Models;
using AutoMapper;
using RV.Services.DataProviderServices;
using RV.Services.DataProviderServices.SQL;
using RV.Services.Mappers;
using RV.Repositories;
using RV.Repositories.SQLRepositories;
using RV.Repository;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("Host=localhost;Port=5432;Database=distcomp;Username=postgres;Password=postgres");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));

builder.Services.AddTransient<IUserRepository, SQLUserRepository>();
builder.Services.AddTransient<INewsRepository, SQLNewsRepository>();
builder.Services.AddTransient<INoteRepository, SQLNoteRepository>();
builder.Services.AddTransient<IStickerRepository, SQLStickerRepository>();

builder.Services.AddTransient<IUserDataProvider, SQLUserDataProvider>();
builder.Services.AddTransient<INewsDataProvider, SQLNewsDataProvider>();
builder.Services.AddTransient<INoteDataProvider, SQLNoteDataProvider>();
builder.Services.AddTransient<IStickerDataProvider, SQLStickerDataProvider>();

builder.Services.AddTransient<IDataProvider, DataProvider>();

builder.Services.AddAutoMapper(typeof(UserMapper));
builder.Services.AddAutoMapper(typeof(NewsMapper));
builder.Services.AddAutoMapper(typeof(NoteMapper));
builder.Services.AddAutoMapper(typeof(StickerMapper));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var serviceProvider = app.Services;
// Получение требуемого сервиса
//var myService = serviceProvider.GetRequiredService<IDataProvider>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
