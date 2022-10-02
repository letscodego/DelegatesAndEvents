namespace DelegatesAndEvents
{
    public class ProcessData
    {
        public void Process(int x, int y, BizRuleDelegate bizRule)
        {
            var result = bizRule.Invoke(x, y);
            Console.WriteLine(result);
        }
    }
}
