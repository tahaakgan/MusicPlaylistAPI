

namespace MusicPlaylistApi.Dtos;

public class SongQueryParameters
{
    public int Page { get; set; } = 1;

    public int PageSize { get; set; } = 5;

    public string? SortBy { get; set; } = "title";

    public bool IsAsc { get; set; } = true;

    public string? Genre { get; set; }
    public string? Artist{ get; set; }
}