namespace ProductivityTracker.Models;

public class ReadingSession
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public TimeSpan Duration { get; set; }
    public required string Title { get; set; }
    public string? Authors { get; set; }
    public int PagesRead { get; set; }
    public int TotalPages { get; set; }
}
