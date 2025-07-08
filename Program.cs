using Microsoft.EntityFrameworkCore;
using MusicPlaylistApi.Data;
using MusicPlaylistApi.Endpoints;
using MusicPlaylistApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MusicContext>(options =>
options.UseSqlite("Data Source=music.db"));

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapSongsEndpoints();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.Run();

