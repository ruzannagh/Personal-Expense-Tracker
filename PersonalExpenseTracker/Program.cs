using Microsoft.EntityFrameworkCore;
using PersonalExpenseTracker.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  

builder.Services.AddDbContext<PETAppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PETDatabase")));

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();