namespace ProductivityTracker.Models;

public class Workout
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public TimeSpan Duration { get; set; }
    public required IList<Exercise> Exercise { get; set; }
    public IList<Run>? Run { get; set; }
}
