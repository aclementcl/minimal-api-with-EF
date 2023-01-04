using entityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddDbContext<EFContext>(x => x.UseInMemoryDatabase("HousesDB"));
builder.Services.AddSqlServer<EFContext>(builder.Configuration.GetConnectionString("cnnHouses"));

var app = builder.Build();

app.MapGet("/dbConnection", async ([FromServices] EFContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok($"Database created: {dbContext.Database.IsSqlServer()}");
});

app.Run();
