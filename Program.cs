using webapi;
using webapi.Models;
using webapi.Services;

var builder = WebApplication.CreateBuilder(args);

// Inyecciones de dependencias

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<TareasContext>("Data Source=LAPTO-DOUGLAS\\SQLEXPRESS;Initial Catalog=TareasDb;user id=sa;password=D1v1$oC62Car");
//builder.Services.AddScoped<IHelloWorldService, HelloWorldService>();
builder.Services.AddScoped<IHelloWorldService>(p => new HelloWorldService());
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ITareasService, TareasService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseWelcomePage();

//app.UseTimeMiddleware();

app.MapControllers();

app.Run();
