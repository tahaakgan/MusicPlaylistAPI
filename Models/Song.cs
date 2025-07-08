using System;

namespace MusicPlaylistApi.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;

    public string Artist { get; set; } = default!;

    public string Genre { get; set; } = default!;

    public TimeSpan Duration { get; set; }

    public int? PlaylistId { get; set; }

    public Playlist? Playlist { get; set; }
}
