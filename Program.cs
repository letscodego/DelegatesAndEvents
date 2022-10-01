WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);

DoWork(del1);
Console.ReadLine();

static void DoWork(WorkPerformedHandler del) => del(5, WorkType.GoToMeeting);


static void WorkPerformed1(int hurs, WorkType workType) => Console.WriteLine($"WorkPerformed1 called. Hours: {hurs}");

static void WorkPerformed2(int hurs, WorkType workType) => Console.WriteLine($"WorkPerformed2 called. Hours: {hurs}");


delegate void WorkPerformedHandler(int hours, WorkType workType);
public enum WorkType
{
    GoToMeeting,
    Footbal,
    Coding
}

