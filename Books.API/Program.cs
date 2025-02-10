using Books.API.DbContexts;
using Books.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register the DbContext on the service container, getting the connection string from appsettings.json
builder.Services.AddDbContext<BooksContext>(options =>
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BooksDBConnectionString"]));

// Register the repository
builder.Services.AddScoped<IBooksRepository, BooksRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
