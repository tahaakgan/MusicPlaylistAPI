using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicPlaylistApi.Data;
using MusicPlaylistApi.Dtos;
using MusicPlaylistApi.Models;
using MiniValidation;

namespace MusicPlaylistApi.Endpoints;
/*
public static class SongsEndpoints
{
    public static void MapSongsEndpoints(this WebApplication app)
    {
        app.MapGet("/songs", async (MusicContext db) =>
        {
            var songs = await db.Songs.ToListAsync();
            return Results.Ok(songs);
        });

        app.MapGet("/songs/{id}", async (int id, MusicContext db) =>
        {
            var song = await db.Songs.FindAsync(id);
            return song is not null ? Results.Ok(song) : Results.NotFound();

        });

        app.MapPost("/songs", async (CreateSongDto newSongDto, MusicContext db) =>
        {
            if (!MiniValidator.TryValidate(newSongDto, out var errors))
                return Results.ValidationProblem(errors);

            var song = new Song
            {
                Title = newSongDto.Title,
                Artist = newSongDto.Artist,
                Genre = newSongDto.Genre,
                Duration = newSongDto.Duration
            };

            await db.Songs.AddAsync(song);
            await db.SaveChangesAsync();

            return Results.Created($"/songs/{song.Id}", song);
        });

        app.MapPut("/songs/{id}", async (int id, CreateSongDto updatedSongDto, MusicContext db) =>
        {
            if (!MiniValidator.TryValidate(updatedSongDto, out var errors))
                return Results.ValidationProblem(errors);

            var song = await db.Songs.FindAsync(id);
            if (song is null)
                return Results.NotFound();

            song.Title = updatedSongDto.Title;
            song.Artist = updatedSongDto.Artist;
            song.Genre = updatedSongDto.Genre;
            song.Duration = updatedSongDto.Duration;

            await db.SaveChangesAsync();

            return Results.Ok(song);
        });

        app.MapDelete("/songs/{id}", async (int id, MusicContext db) =>
        {
            var song = await db.Songs.FindAsync(id);

            if (song is null)
                return Results.NotFound();

            db.Songs.Remove(song);
            await db.SaveChangesAsync();

            return Results.NoContent();
        });

        app.MapGet("/song/genre/{genre}", async (string genre, MusicContext db) =>
        {
            var songs = await db.Songs
            .Where(s => string.Equals(s.Genre, genre, StringComparison.OrdinalIgnoreCase))
            .ToListAsync();

            return Results.Ok(songs);
        });

        app.MapGet("/song/artist/{artist}", async (string artist, MusicContext db) =>
        {
            var songs = await db.Songs.Where(s => s.Artist.ToLower().Contains(artist.ToLower()))
            .ToListAsync();

            return Results.Ok(songs);
        });

        app.MapPost("/playlists", async (CreatePlaylistDto createdPlaylistdto, MusicContext db) =>
        {
            var playlist = new Playlist
            {
                Name = createdPlaylistdto.Name
            };

            await db.Playlists.AddAsync(playlist);
            await db.SaveChangesAsync();

            return Results.Created($"/playlists/{playlist.Id}", playlist);
        });

    }
}*/