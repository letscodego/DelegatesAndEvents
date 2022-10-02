namespace DelegatesAndEvents
{
    public class ProcessData
    {
        public void Process(int x, int y, BizRuleDelegate bizRule)
        {
            var result = bizRule.Invoke(x, y);
            Console.WriteLine(result);
        }

        public void ProcessAction(int x, int y, Action<int, int> action)
        {
            action(x, y);
            Console.WriteLine("Action is done!");
        }
    }
}
