namespace CSharpAdvance;

public struct Nullable<T> where T : struct
{
    private readonly T value;
    private readonly bool hasValue;
    public Nullable(T value)
    {
        this.value = value;
        this.hasValue = true;
    }
    public bool HasValue { get { return hasValue; } }

    public T Value
    {
        get
        {
            if (!hasValue)
            {
                throw new InvalidOperationException();
            }
            return value;
        }
    }
}