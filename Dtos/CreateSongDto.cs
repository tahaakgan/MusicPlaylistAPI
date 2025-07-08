using System.ComponentModel.DataAnnotations;

namespace MusicPlaylistApi.Dtos;

public record class CreateSongDto
{
    [Required(ErrorMessage = "Title is needed.")]
    [StringLength(50,MinimumLength =1,ErrorMessage ="Title must be between 1 and 50 char.")]
    public required string Title { get; set; } = default!;

    [Required(ErrorMessage = "Artist is needed.")]
    [StringLength(30,ErrorMessage ="Artist name is too long")]
    public required string Artist { get; set; } = default!;

    [Required(ErrorMessage = "Genre is needed.")]
    [StringLength(30,ErrorMessage ="Genre is too long.")]
    public required string Genre { get; set; } = default!;

    [Range(typeof(TimeSpan), "00:01:00", "02:00:00", ErrorMessage ="Duration must be between 1 and 120 minutes.")]
    public required TimeSpan Duration { get; set; }

}
