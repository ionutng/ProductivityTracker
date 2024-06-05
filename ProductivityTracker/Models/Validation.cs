namespace ProductivityTracker.Models;

public static class Validation
{
    public static bool DateValidation(DateOnly date, TimeOnly startTime, TimeOnly endTime)
    {
        if (date > DateOnly.FromDateTime(DateTime.Now))
        {
            MessageBox.Show("You cannot select a future date!");
            return false;
        }

        if (endTime < startTime || endTime == startTime)
        {
            MessageBox.Show("The end time cannot be lower than or equal to the start time!");
            return false;
        }

        return true;
    }

    public static bool ExerciseValidation(string name, int sets, int reps)
    {
        if (name == "")
        {
            MessageBox.Show("Exercise name cannot be empty!");
            return false;
        }

        foreach (char character in name)
        {
            if (char.IsDigit(character))
            {
                MessageBox.Show("You cannot input digits for an exercise's name!");
                return false;
            }
        }

        if (sets == 0 || reps == 0)
        {
            MessageBox.Show("You cannot input zero or a negative value!");
            return false;
        }

        return true;
    }

    public static bool RunValidation(string distanceString, TimeSpan time, TimeSpan pace)
    {
        if (!float.TryParse(distanceString, out float distance))
        {
            MessageBox.Show("Please input a correct distance! (i.e. 2.07)");
            return false;
        }

        if (distance <= 0)
        {
            MessageBox.Show("You cannot input zero or a negative value!");
            return false;
        }

        if (time == new TimeSpan(0, 0, 0))
        {
            MessageBox.Show("Time cannot be 0!");
            return false;
        }

        if (pace == new TimeSpan(0, 0, 0))
        {
            MessageBox.Show("Pace cannot be 0!");
            return false;
        }

        return true;
    }

    public static bool ReadingSessionValidation(string title, string authors, int totalPages, int pagesRead)
    {
        if (title == "")
        {
            MessageBox.Show("Please input the title of the book!");
            return false;
        }

        foreach (char character in authors)
        {
            if (char.IsDigit(character))
            {
                MessageBox.Show("You cannot input digits for an author's name!");
                return false;
            }
        }

        if (totalPages == 0)
        {
            MessageBox.Show("You cannot input zero or a negative value for pages!");
            return false;
        }

        if (pagesRead > totalPages)
        {
            MessageBox.Show("Pages read cannot be bigger than total pages!");
            return false;
        }

        return true;
    }
}
