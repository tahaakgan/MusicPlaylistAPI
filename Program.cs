using Microsoft.EntityFrameworkCore;
using MusicPlaylistApi.Data;
using MusicPlaylistApi.Endpoints;
using MusicPlaylistApi.Models;
using MusicPlaylistApi.Middlewares;
using MusicPlaylistApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MusicContext>(options =>
options.UseSqlite("Data Source=music.db"));

builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

/*app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseMiddleware<RequestLoggingMiddleware>();
app.MapSongsEndpoints();*/


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseRouting();
app.MapControllers();

app.Run();

