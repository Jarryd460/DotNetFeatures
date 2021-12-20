namespace InOutKeywords;

internal static class OutExample
{
    public static (bool couldParse, int parsedValue) TryParse(string valueToParse)
    {
        var success = int.TryParse(valueToParse, out var value);

        return (success, value);
    }

    // Passing in a parameter without any keyword creates a copy of the value
    // and any changes to that value inside the method does not affect the value on the outside
    //public static void ExampleOut(int value)
    //{
    //    value = 10;
    //}

    // Passing in a parameter with ref keyword passes the address of where the value is stored
    // and not a copy of the value itself. This causes changes to the value inside the method to
    // be reflected outside the method as well as they both point to the same memory address.
    //public static void ExampleOut(ref int value)
    //{
    //    value = 10;
    //}

    // Passing in a parameter with out keyword behaves exactly like the ref keyword with the addition
    // of the compiler forcing the developer to set the value inside the method regardless of wether it
    // was set on the outside.
    // The out keyword can not be used with async, yield break, yield return and iteration features.
    // The ExampleOut method below can have a overloaded version without the out keyword as well. It cannot
    // however have a overloaded version with the ref keyword.
    public static void ExampleOut(out int value)
    {
        value = 10;
    }
}
