using FakeBooking.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Between singleton and transient, scoped is the most common choice for web applications.
builder.Services.AddScoped<ITouristRouteRepository, MockTouristRouteRepository>();
//// Singleton suitable for shared data or status, such as configuration or application state.
//builder.Services.AddSingleton
//// Suitable for lightweight, stateless services that can be reused across requests, such as logging or caching.
//builder.Services.AddTransient

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

app.Run();
