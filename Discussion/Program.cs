using Discussion.Models;
using Discussion.Repositories;
using Discussion.Repositories.SQLRepositories;
using Discussion.Services.DataProviderServices;
using Discussion.Services.DataProviderServices.SQL;
using Discussion.Services.Mappers;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

/*NoSQLNoteRepository test = new NoSQLNoteRepository();
var n = new Note()
{
    content = "test",
    country = "test",
    id = 1,
    newsId = 1
};
test.Delete(10);*/
//s = test.Get(10);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IRepository<Note>, NoSQLNoteRepository>();

builder.Services.AddTransient<INoteDataProvider, NoSQLNoteDataProvider>();

builder.Services.AddAutoMapper(typeof(NoteMapper));

builder.Services.AddTransient<IDataProvider, DataProvider>();

builder.Services.AddControllers();

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
