using DelegatesAndEvents;

var work = new Worker();
work.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
work.WorkCompleted += new EventHandler(Worker_WorkCompleted);
work.DoWork(8, WorkType.Coding);


static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
{
    Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
}

static void Worker_WorkCompleted(object sender, EventArgs e)
{
    Console.WriteLine("Worker is done");
}

public enum WorkType
{
    GoToMeeting,
    Footbal,
    Coding
}

