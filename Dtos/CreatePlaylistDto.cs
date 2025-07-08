using System.ComponentModel.DataAnnotations;

namespace MusicPlaylistApi.Dtos;

public record class CreatePlaylistDto
{
    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string Name { get; set; } = default!;
    
}