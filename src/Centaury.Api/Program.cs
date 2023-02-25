using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo {
        Title = "Centaury API",
        Version = "v1"        
    });
});


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.DocExpansion(DocExpansion.None);
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Task v1");
        c.RoutePrefix = string.Empty; });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
