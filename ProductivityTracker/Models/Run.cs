namespace ProductivityTracker.Models;

internal class Run
{
    public int Id { get; set; }
    public float Distance { get; set; }
    public TimeSpan Time { get; set; }
    public TimeSpan Pace { get; set; }
    public int WorkoutId { get; set; }
}
