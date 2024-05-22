namespace ProductivityTracker.Models;

internal class ReadingSession
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Authors { get; set; }
    public int PagesRead { get; set; }
    public int TotalPages { get; set; }
}
