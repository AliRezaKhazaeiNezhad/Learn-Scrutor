using LegoLearn.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient(typeof(ServiceTwo));
builder.Services.AddTransient(typeof(IServiceOne), typeof(ServiceOne));
builder.Services.AddTransient(typeof(IRepositoryOne<>), typeof(RepositoryOne<>));

var app = builder.Build();
app.UseRouting();
app.MapControllers();

app.Run();
