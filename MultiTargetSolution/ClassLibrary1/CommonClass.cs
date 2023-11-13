namespace ClassLibrary1;

public class CommonClass
{
    private readonly int _value;

    public CommonClass(int value)
    {
        _value = value;
    }

    public int UsedByNet4() => _value + 4;

    public int UsedByNet6() => _value + 6;

    public int UsedByNet6Windows() => _value + 1006;

    public int UnusedMethod() => _value + 42;
}