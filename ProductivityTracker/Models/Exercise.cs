namespace ProductivityTracker.Models;

internal class Exercise
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public int WorkoutId { get; set; }
}
