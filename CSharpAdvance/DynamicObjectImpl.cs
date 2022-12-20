namespace CSharpAdvance;
using System.Dynamic;

class SimpleDynamicExample : DynamicObject
{
    public override bool TryInvokeMember(
        InvokeMemberBinder binder,
        object?[]? args,
        out object ? result)
    {
        Console.WriteLine("Invoked: {0}({1})",
            binder.Name, string.Join(", ", args));
        result = null;
        return true;
    }
    public override bool TryGetMember(
        GetMemberBinder binder,
        out object result)
    {
        result = "Fetched: " + binder.Name;
        return true;
    }
}