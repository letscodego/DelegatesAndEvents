using DelegatesAndEvents;

var work = new Worker();
work.WorkPerformed += Work_WorkPerformed;
work.WorkCompleted += Work_WorkCompleted;

work.DoWork(8, WorkType.Coding);


void Work_WorkPerformed(object? sender, WorkPerformedEventArgs e)
{
    Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
}

void Work_WorkCompleted(object? sender, EventArgs e)
{
    Console.WriteLine("Worker is done");
}

public enum WorkType
{
    GoToMeeting,
    Footbal,
    Coding
}

