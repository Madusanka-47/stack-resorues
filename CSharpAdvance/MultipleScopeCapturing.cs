namespace CSharpAdvance;

#region Multiple Scope Capturing (related to: lamda experssions) ex000013
public static class MultipleScopeCapturing
{
     //  the same outer counter is used by both delegates, but they have independent inner counters
   public static List<Action> CreateCountingActions()
    {
        List<Action> actions = new List<Action>();
        int outerCounter = 0;
        for (int i = 0; i < 2; i++)
        {
            int innerCounter = 0;
            Action action = () =>
            {
                Console.WriteLine("Outer: {0}; Inner: {1}", outerCounter, innerCounter);
                outerCounter++;
                innerCounter++;
            };
            actions.Add(action);
        }
        return actions;
    }
}
#endregion