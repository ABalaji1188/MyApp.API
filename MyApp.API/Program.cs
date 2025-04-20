using MyApp.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
// Register Swagger generator
builder.Services.AddSwaggerGen();
builder.Services.AddAppDI();
builder.Services.AddControllers();

var app = builder.Build();

// Enable middleware to serve generated Swagger as JSON endpoint
 app.UseSwagger();
// Configure the HTTP request pipeline.

// Enable middleware to serve Swagger UI (HTML)
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});
app.UseAuthorization();

app.MapControllers();

app.Run();
