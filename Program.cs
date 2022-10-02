using DelegatesAndEvents;
using System;

//using lambdas with delegates
BizRuleDelegate addDel = (x, y) => x + y;
BizRuleDelegate multiplyDel = (x, y) => x * y;

var data = new ProcessData();
data.Process(3, 5, addDel);


//using anonymous methofs
var work = new Worker();
work.WorkPerformed += (s, e) => Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");  //Work_WorkPerformed;
work.WorkCompleted += (s, e) => Console.WriteLine("Worker is done");  //Work_WorkCompleted;

work.DoWork(8, WorkType.Coding);


//void Work_WorkPerformed(object? sender, WorkPerformedEventArgs e)
//{
//    Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
//}

//void Work_WorkCompleted(object? sender, EventArgs e)
//{
//    Console.WriteLine("Worker is done");
//}

public delegate int BizRuleDelegate(int i, int j);
public enum WorkType
{
    GoToMeeting,
    Footbal,
    Coding
}

