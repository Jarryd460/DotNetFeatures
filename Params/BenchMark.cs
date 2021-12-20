using BenchmarkDotNet.Attributes;

namespace Params;

[MemoryDiagnoser(false)]
public class BenchMark
{
    private readonly int[] _array = { 4, 2, 0, 6, 9 };

    [Benchmark]
    public int Add_WithParams_Inline()
    {
        return Add_WithParams(4, 2, 0, 6, 9);
    }

    [Benchmark]
    public int Add_WithParams_Single_WithParams()
    {
        return Add_WithParams(4);
    }

    [Benchmark]
    public int Add_WithParams_Single_WithoutParams()
    {
        return Add_WithParams_Single(4);
    }

    [Benchmark]
    public int Add_WithParams_Array()
    {
        return Add_WithParams(_array);
    }

    [Benchmark]
    public int Add_WithParams_Empty()
    {
        // Equivalent to Add_WithParams(Array.Empty<int>())
        return Add_WithParams();
    }

    [Benchmark]
    public int Add_WithoutParams_Array()
    {
        return Add_WithoutParams(_array);
    }

    private int Add_WithParams(params int[] numbers)
    {
        var sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    private int Add_WithParams_Single(int numbers)
    {
        return numbers;
    }

    private int Add_WithoutParams(int[] numbers)
    {
        var sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }
}
