using LegoLearn.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient(typeof(IServiceOne), typeof(ServiceOne));

var app = builder.Build();
app.UseRouting();
app.MapControllers();

app.Run();
