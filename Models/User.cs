using System.ComponentModel.DataAnnotations;

namespace MusicPlaylistApi.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Username { get; set; } = default!;

    [Required]
    public string PasswordHash { get; set; } = default!;

}