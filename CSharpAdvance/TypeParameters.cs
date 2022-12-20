namespace CSharpAdvance;
using System.Globalization;
public class TypeParameters
{

    #region Type Constrains ex000002
    public void PrintItems<T>(List<T> items) where T : IFormattable
    {
        CultureInfo culture = CultureInfo.InvariantCulture;
        foreach (T item in items)
        {
            Console.WriteLine(item.ToString(null, culture));
        }
    }
    #endregion

    #region Type Parameters & Arguments ex000005
    public List<T> CopyAtMost<T>(List<T> input, int maxElements)
    {
        int actualCount = Math.Min(input.Count, maxElements);
        List<T> ret = new List<T>(actualCount);
        for (int i = 0; i < actualCount; i++)
        {
            ret.Add(input[i]);
        }
        return ret;
    }
    #endregion
    
}