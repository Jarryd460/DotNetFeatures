namespace InOutKeywords;

static internal class InExample
{
    // When accessing properties on struct that is not readonly, it is important not to use the in keyword as it will create
    // defensive copies of the struct in the background. If the properties accessed in the method are readonly
    // it is then best to use in keyword.
    public static double CalculateDistance(in Point point1, in Point point2)
    {
        double xDifference = point1.X - point2.X;
        double yDifference = point1.Y - point2.Y;
        double zDifference = point1.Z - point2.Z;

        return Math.Sqrt(xDifference * xDifference + yDifference * yDifference + zDifference * zDifference);
    }
}

// Struct that is not readonly
//internal struct Point
//{
//    public double _x;
//    public double _y;
//    public double _z;

//    public double X { get => _x; set => _x = value; }
//    public double Y { get => _y; set => _y = value; }
//    public double Z { get => _z; set => _z = value; }

//    public Point(int x, int y, int z)
//    {
//        _x = x;
//        _y = y;
//        _z = z;
//    }
//}

// Readonly struct
internal struct Point
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}