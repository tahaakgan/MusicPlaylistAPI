using Microsoft.EntityFrameworkCore;
using MusicPlaylistApi.Models;
using MusicPlaylistApi.Data;

namespace MusicPlaylistApi.Data;

public class MusicContext : DbContext
{
    public MusicContext(DbContextOptions<MusicContext> options) : base(options) { }

    public DbSet<Song> Songs => Set<Song>();

    public DbSet<Playlist> Playlists => Set<Playlist>();
}