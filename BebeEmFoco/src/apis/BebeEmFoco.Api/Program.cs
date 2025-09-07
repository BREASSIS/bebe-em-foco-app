using BebeEmFoco.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Serviços
builder.Services.AddControllers();
builder.Services.AddSwaggerConfiguration();
builder.Services.AddCorsConfiguration();
builder.Services.AddAuthenticationConfiguration(builder.Configuration);
builder.Services.AddLoggingConfiguration();

var app = builder.Build();

// Middlewares
app.UseSwaggerConfiguration();
app.UseCorsConfiguration();
app.UseAuthenticationConfiguration();

app.MapControllers();
app.Run();
