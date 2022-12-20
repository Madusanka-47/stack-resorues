namespace CSharpAdvance;
using System.Linq.Expressions;
public class ExpressionTree
{
    public void ExpressionBuild()
    {
        #region Expression Tree ex000014
        Expression<Func<int, int, int>> adder = (x, y) => x + y;
        Console.WriteLine(adder);
        #endregion

        // Hand written!
        ParameterExpression xParameter = Expression.Parameter(typeof(int), "x");
        ParameterExpression yParameter = Expression.Parameter(typeof(int), "y");
        Expression body = Expression.Add(xParameter, yParameter);
        ParameterExpression[] parameters = new[] { xParameter, yParameter };
        Expression<Func<int, int, int>> adder2 = Expression.Lambda<Func<int, int, int>>(body, parameters);
        var executableAdder = adder2.Compile();
        Console.WriteLine(executableAdder(2,2));
    }
}