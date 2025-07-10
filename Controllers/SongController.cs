using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlaylistApi.Data;
using MusicPlaylistApi.Models;
using MusicPlaylistApi.Dtos;
using SQLitePCL;

namespace MusicPlaylistApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SongsController : ControllerBase
{
    private readonly MusicContext _context;

    public SongsController(MusicContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Song>>> GetSongs()
    {
        var songs = await _context.Songs.ToListAsync();
        return Ok(songs);
    }

    [HttpGet("{id}")]

    public async Task<ActionResult<Song>> GetSong(int id)
    {
        var song = await _context.Songs.FindAsync(id);

        if (song == null)
        {
            return NotFound();
        }
        return Ok(song);
    }

    [HttpPost]
    public async Task<ActionResult<Song>> CreateSong([FromBody] CreateSongDto newSongDto)
    {
        var song = new Song
        {
            Title = newSongDto.Title,
            Artist = newSongDto.Artist,
            Genre = newSongDto.Genre,
            Duration = newSongDto.Duration
        };

        _context.Songs.Add(song);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetSong), new { id = song.Id }, song);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Song>> UpdateSong(int id, [FromBody] CreateSongDto updatedSongDto)
    {
        var song = await _context.Songs.FindAsync(id);

        if (song == null)
            return NotFound();

        song.Title = updatedSongDto.Title;
        song.Artist = updatedSongDto.Artist;
        song.Genre = updatedSongDto.Genre;
        song.Duration = updatedSongDto.Duration;


        await _context.SaveChangesAsync();

        return Ok(song);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteSong(int id)
    {
        var song = await _context.Songs.FindAsync(id);

        if (song is null)
            return NotFound();

        _context.Songs.Remove(song);
        await _context.SaveChangesAsync();

        return NoContent();

    }
}

