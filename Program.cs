using DelegatesAndEvents;
using System;

//using lambdas with delegates
BizRuleDelegate addDel = (x, y) => x + y;
BizRuleDelegate multiplyDel = (x, y) => x * y;

var data = new ProcessData();
data.Process(3, 5, addDel);

//using Action
Action<int, int> myAction;
Action<int, int> myAddAction = (x, y) => Console.WriteLine(x + y);
Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);

myAction = 
    DateTime.Now.DayOfWeek == DayOfWeek.Sunday ?
    myAddAction : 
    myMultiplyAction;

data.ProcessAction(3, 6, myAction);

//using Func
Func<int, int, int> myFunc;
Func<int, int, int> myAddFunc = (x, y) => x + y;
Func<int, int, int> myMultiplyFunc = (x, y) => x * y;

myFunc =
    DateTime.Now.DayOfWeek == DayOfWeek.Sunday ?
    myAddFunc :
    myMultiplyFunc;

data.ProcessFunc(3, 21, myFunc);

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

