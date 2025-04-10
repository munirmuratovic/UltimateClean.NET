using Microsoft.EntityFrameworkCore;
using UltimateClean.Application;
using UltimateClean.Persistence;
using UltimateClean.Persistence.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. (maybe move it outside, in separate file/class)
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// ✅ Apply migrations here, before `app.Run()`
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<MyDbContext>();
    db.Database.Migrate(); // applies pending migrations
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseRouting();

// app.UseAuthorization();

app.MapControllers();

app.Run();
