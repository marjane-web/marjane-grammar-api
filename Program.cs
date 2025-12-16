var builder = WebApplication.CreateBuilder(args);

// 🔥 ADD CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

// Controllers
builder.Services.AddControllers();

var app = builder.Build();

// 🔥 USE CORS (IMPORTANT)
app.UseCors("AllowAll");

app.MapControllers();
app.Run();
