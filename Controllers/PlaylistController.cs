using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicPlaylistApi.Data;
using MusicPlaylistApi.Models;
using MusicPlaylistApi.Dtos;
using SQLitePCL;

namespace MusicPlaylistApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlaylistController : ControllerBase
{
    private readonly MusicContext _context;

    public PlaylistController(MusicContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Song>>> GetPlaylists()
    {
        var playlists = await _context.Playlists.ToListAsync();
        return Ok(playlists);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Song>> GetPlaylist(int id)
    {

        var playlist = await _context.Playlists.FindAsync(id);

        if (playlist == null)
        {
            return NotFound();
        }
        return Ok(playlist);
    }

    [HttpPost]
    public async Task<ActionResult<Playlist>> CreatePlaylist([FromBody] CreatePlaylistDto createdPlaylist)
    {
        var songs = await _context.Songs.Where(s => createdPlaylist.SongIds.Contains(s.Id)).ToListAsync();
        var playlist = new Playlist
        {
            Name = createdPlaylist.Name,
            Songs = songs
        };

        await _context.Playlists.AddAsync(playlist);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPlaylist), new { id = playlist.Id }, playlist);
    }
}