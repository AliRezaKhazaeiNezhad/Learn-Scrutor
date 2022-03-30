using LegoLearn.Server.Services;
using LegoLearn.Services;
using System.Reflection;

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




/// <summary>
/// جلسه پنجم
/// </summary>
//builder.Services.Scan(current => current
//    .FromCallingAssembly()
//    .AddClasses(theClass => theClass.InExactNamespaceOf<LegoLearn.Server.Services.ServiceOne>())
//    .AsSelf()
//    .AsImplementedInterfaces()
//    .WithTransientLifetime()


//    .FromCallingAssembly()
//    .AddClasses(theClass => theClass.InExactNamespaceOf<LegoLearn.Server.RepositoryServices.IServiceOne>())
//    .AsSelf()
//    .AsImplementedInterfaces()
//    .WithTransientLifetime()
//);






/// <summary>
/// جلسه ششم
/// </summary>
//builder.Services.Scan(current => current
//    .FromAssemblies(typeof(MyServiceOne).GetTypeInfo().Assembly)
//    .AddClasses(theClass => theClass.InExactNamespaceOf<LegoLearn.Services.IMyServiceOne>())
//    .AsSelf()
//    .AsImplementedInterfaces()
//    .WithTransientLifetime()
//);





var app = builder.Build();
app.UseRouting();
app.MapControllers();

app.Run();
