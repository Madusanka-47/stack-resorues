// extern alias JsonNet;
// extern alias JsonNetAlternative;

// using JsonNet::Newtonsoft.Json.Linq;
// using AltJObject = JsonNetAlternative::Newtonsoft.Json.Linq.JObject;

using System.Runtime.CompilerServices;

namespace CSharpAdvance;
class Program
{
    static void Main(string[] args)
    {
        #region Anonymous types ex000001
        var book = (title: "Lost in the Snow", author: "Holly Webb");
        Console.WriteLine(book.title);
        #endregion


        List<int> numbers = new List<int> { 5, 10, 20 };
        var type = new TypeParameters();

        // ex000005
        List<int> firstTwo = type.CopyAtMost<int>(numbers, 2);
        Console.WriteLine(firstTwo.Count);

        // ex000002
        type.PrintItems<int>(numbers);

        #region Tuples ex000007
        Tuple.Create(10, "x", 20); // Prefered
        new Tuple<int, string, int>(10, "x", 20);
        #endregion

        // ex000008
        new Outer<string>.Inner<int>();

        #region Boxing & Unboxing ex000009
        int i = 12;
        object box = i;
        if (box is int)
        {
            Console.Write("Box contains an int");
        }
        #endregion

        #region Nullable ex000010
        int? nullableInt = new int();
        bool is_ = nullableInt.HasValue;
        var value = new Nullable<decimal>(1);
        DisplayMaxPrice(value);

        // ex000009 ex000010
        int? nullable = box as int?;
        #endregion


        // ex000003
        var a = new Fraction(5, 4);
        var b = new Fraction(1, 2);
        Console.WriteLine(-a);
        Console.WriteLine(-a - b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);

        #region Null-Coalescing Operator ex000004
        int? value1 = 5;
        int value2 = 10;
        int value3 = value1 ?? value2;
        #endregion

        #region Multicasting Deligates ex000011
        EventHandler handler = HandleButtonClick;
        handler += HandleButtonClick;
        #endregion

        #region Wrapping Deligates ex000012
        Printer p1 = new Printer(PrintAnything);
        p1("overloading");
        // Delegate wrap on a delegate
        GeneralPrinter generalPrinter = new GeneralPrinter(PrintAnything);
        var param = new Printer(generalPrinter);
        #endregion

        IEnumerable<int> enumerable = CreateSimpleIterator();
        using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                int values = enumerator.Current;
                Console.WriteLine(values);
            }
        }

        // #pragma 

        // Implicit array 
        // array = new[] { 1, 2, 3, 4, 5 };
        // var array = new[,] { { 1, 2, 3 }, { 4, 5, 6 } };

        // ex000013
        List<Action> actions = MultipleScopeCapturing.CreateCountingActions();
        actions[0]();
        actions[0]();
        actions[1]();
        actions[1]();

        // ex000016
        Method(1, y: 2);
        Method(1, z: 3);

    }
    public static void DisplayMaxPrice(Nullable<decimal> maxPriceFilter)
    {
        if (maxPriceFilter.HasValue)
        {
            Console.WriteLine("Maximum price: {0}", maxPriceFilter.Value);
        }
        else
        {
            Console.WriteLine("No maximum price set.");
        }
    }

    // ex000011
    private static void HandleButtonClick(object sender, EventArgs e)
    {

    }

    public static void PrintAnything(object obj)
    {
        Console.WriteLine(obj);
    }

    static IEnumerable<int> CreateSimpleIterator()
    {
        yield return 10;
        for (int i = 0; i < 3; i++)
        {
            yield return i;
        }
        yield return 20;
    }

    #region Optional Parameters ex000016
    static void Method(int x, int y = 5, int z = 10)
    {
        Console.WriteLine("x={0}; y={1}; z={2}", x, y, z);
    }
    #endregion

    public void sampleMethod(
        [CallerFilePath] string name = null,
        [CallerLineNumber] int number = 0,
        [CallerMemberName] string member = null)
    {

    }
}