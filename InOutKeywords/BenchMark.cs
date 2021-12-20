namespace InOutKeywords;

public class BenchMark
{
    [BenchmarkDotNet.Attributes.Benchmark]
    public void MutableAddByType()
    {
        var mutableStruct = new MutableStruct(1, 2, 3);
        AddByType(mutableStruct);
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public void MutableAddByRefType()
    {
        var mutableStruct = new MutableStruct(1, 2, 3);
        AddByRefType(in mutableStruct);
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public void MutableReadonlyAddByType()
    {
        var mutableStructReadonly = new MutableStructReadonly(1, 2, 3);
        AddByType(mutableStructReadonly);
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public void MutableReadonlyAddByRefType()
    {
        var mutableStructReadonly = new MutableStructReadonly(1, 2, 3);
        AddByRefType(in mutableStructReadonly);
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public void ImmutableAddByType()
    {
        var immutableStruct = new ImmutableStruct(1, 2, 3);
        AddByType(immutableStruct);
    }

    [BenchmarkDotNet.Attributes.Benchmark]
    public void ImmutableAddByRefType()
    {
        var immutableStruct = new ImmutableStruct(1, 2, 3);
        AddByRefType(in immutableStruct);
    }

    private double AddByType(ImmutableStruct s)
    {
        return s.X + s.Y;
    }

    private double AddByRefType(in ImmutableStruct s)
    {
        return s.X + s.Y;
    }

    public double AddByType(MutableStruct s)
    {
        return s.X + s.Y;
    }

    public double AddByRefType(in MutableStruct s)
    {
        return s.X + s.Y;
    }

    public double AddByType(MutableStructReadonly s)
    { 
        return s.X + s.Y;
    }

    public double AddByRefType(in MutableStructReadonly s)
    { 
        return s.X + s.Y;
    }
}

public readonly struct ImmutableStruct
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    private readonly double a;
    private readonly double b;
    private readonly double c;
    private readonly double d;
    private readonly double e;
    private readonly double f;
    private readonly double g;
    private readonly double h;

    public ImmutableStruct(double x = 0, double y = 0, double z = 0)
    {
        X = x;
        Y = y;
        Z = z;
        a = 1;
        b = 2;
        c = 3;
        d = 4;
        e = 5;
        f = 6;
        g = 7;
        h = 8;
    }
}

public struct MutableStruct
{
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public double Z { get => z; set => z = value; }

    private double a;
    private double b;
    private double c;
    private double d;
    private double e;
    private double f;
    private double g;
    private double h;
    private double x;
    private double y;
    private double z;

    public MutableStruct(double x = 0, double y = 0, double z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        a = 1;
        b = 2;
        c = 3;
        d = 4;
        e = 5;
        f = 6;
        g = 7;
        h = 8;
    }
}

public struct MutableStructReadonly
{
    public double X { readonly get => x; set => x = value; }
    public double Y { readonly get => y; set => y = value; }
    public double Z { readonly get => z; set => z = value; }

    private double a;
    private double b;
    private double c;
    private double d;
    private double e;
    private double f;
    private double g;
    private double h;
    private double x;
    private double y;
    private double z;

    public MutableStructReadonly(double x = 0, double y = 0, double z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        a = 1;
        b = 2;
        c = 3;
        d = 4;
        e = 5;
        f = 6;
        g = 7;
        h = 8;
    }
}
