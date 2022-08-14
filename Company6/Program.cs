using Entities.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Company6Context>(opt =>
                    opt.UseSqlServer(builder.Configuration.GetConnectionString("Company6Connection"),
                    m => m.MigrationsAssembly("Company6")));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
