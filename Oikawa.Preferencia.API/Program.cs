using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Add Swagger services - always enabled
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "Preference API - Read Only", 
        Version = "v1",
        Description = "API somente leitura para consultar preferências/gostos de pessoas baseado em seus nomes"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// Swagger habilitado em todos os ambientes (Development e Production)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Preference API V1 - Read Only");
    c.RoutePrefix = "swagger";
    c.DocumentTitle = "Preference API Documentation - Read Only";
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
