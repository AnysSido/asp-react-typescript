var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add static files from spa directory
builder.Services.AddSpaStaticFiles(options => options.RootPath = "clientapp/build");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Serve static files from the spa directory instead of wwwroot
app.UseSpaStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.MapWhen(x => !x.Request.Path.StartsWithSegments("/api"), appBuilder =>
{
    appBuilder.UseSpa(spa =>
    {
        if (app.Environment.IsDevelopment())
        {
            spa.UseProxyToSpaDevelopmentServer("http://127.0.0.1:3000");
        }

        // Rewrite all requests to the spa
        spa.Options.SourcePath = "clientapp";
    });
});

app.Run();
