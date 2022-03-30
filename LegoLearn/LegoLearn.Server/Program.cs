using LegoLearn.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
/// <summary>
/// جلسه اول
/// </summary>
//builder.Services.AddTransient(typeof(ServiceTwo));
//builder.Services.AddTransient(typeof(IServiceOne), typeof(ServiceOne));
//builder.Services.AddTransient(typeof(IRepositoryOne<>), typeof(RepositoryOne<>));

/// <summary>
/// جلسه سوم
/// </summary>
//builder.Services.Scan(current => current
//    .FromCallingAssembly()
//    .AddClasses()

//    .AsSelf()
//    .AsImplementedInterfaces()

//    .WithTransientLifetime()
//);


/// <summary>
/// جلسه چهارم
/// </summary>
//builder.Services.Scan(current => current
//    .FromCallingAssembly()
//    .AddClasses(theClass => theClass.InExactNamespaceOf<LegoLearn.Server.Services.ServiceOne>())
//    .AsSelf()
//    .AsImplementedInterfaces()
//    .WithTransientLifetime()
//);

var app = builder.Build();
app.UseRouting();
app.MapControllers();

app.Run();
