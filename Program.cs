using Microsoft.AspNetCore.Http.Connections;
using UniversityEnrollmentPlatform.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("UniversityPlatform");
builder.Services.AddSqlServer<UniversityPlatformContext>(connectionString);
//builder.Services.AddDbContext<UniversityPlatformContext>(options => options.Use)

var app = builder.Build();
app.MapGet("/", () => "Hello World!");


app.Run();
