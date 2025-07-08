

using System.ComponentModel.DataAnnotations;

namespace MusicPlaylistApi.Models;

public class Playlist
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Playlist must have a name.")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "Playlist has a name between 1 and 50 characters.")]
    public string Name { get; set; } = default!;

    public ICollection<Song> Songs { get; set; } = new List<Song>();

}