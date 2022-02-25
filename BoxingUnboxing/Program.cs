// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using System.Collections;

namespace BoxingUnboxing
{
    public class Program
    {
        public static int Main(string[] args)
        {
            int someNumber = 420;

            // This assignment causes boxing to occur 
            object someObject = someNumber;

            Console.WriteLine(someObject);

            // This assignment unboxes the value. Notice that it's not implicit.
            // You have to explicitly cast it. The boxed value "someObject" will also still be on the heap
            int unboxed = (int)someObject;

            Console.WriteLine(unboxed);

            // This creates an object on the heap that holds an array of values from 69 to 420.
            // Search for Int32, you will see that "Int32 []" holds an object with all the values
            var arrayOfInts = Enumerable.Range(69, 420).ToArray();

            // This boxes each value in "arrayOfInts" as ArrayList internal stores the values in a variable of "object[]"
            // Search for Int32, you will see that Int32 has individual values for all values in "arrayOfInts"
            var arrayList = new ArrayList(arrayOfInts);

            // Using a generic list does not box the values individually as they are store internally as int[]
            var list = new List<int>(arrayOfInts);

            BenchmarkRunner.Run<BenchMark>();

            return 0;
        }
    }
}