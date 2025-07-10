
using System.ComponentModel.DataAnnotations;

namespace MusicPlaylistApi.Dtos;

public record UserLoginDto
{
    [Required]
    public string Username { get; set; } = default!;

    [Required]
    public string Password { get; set; } = default!;
}
