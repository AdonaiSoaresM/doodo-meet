using backend.Configuration;
using backend.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddKeycloakAuthConfiguration(builder.Configuration);
builder.Services.AddUserRequestContext();
builder.Services.AddDbContextConfiguration(builder.Configuration);
builder.Services.AddDependecyInjection();
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.ConfigureCORS(builder.Configuration);

EFConfiguration.MigrateDatabase(builder.Configuration);

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapHub<AppHub>("/hub");
app.MapControllers();

app.Run();
