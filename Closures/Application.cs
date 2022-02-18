namespace Closures
{
    internal class Application
    {
        private static readonly List<int> SomeNumbers = Enumerable.Range(0, 1000).ToList();

        public void Run()
        {
            var numbersOverNumberUsingLinq = GetNumbersOverNumberUsingLinq(400);
            Console.WriteLine($"Number was {numbersOverNumberUsingLinq}");

            var numbersOverNumberInternalNumberScoped = GetNumbersOverNumberMethodScoped();
            Console.WriteLine($"Number was {numbersOverNumberInternalNumberScoped}");

            var numbersOverNumberConstantNumber = GetNumbersOverNumberConstantNumber();
            Console.WriteLine($"Number was {numbersOverNumberConstantNumber}");

            var numbersOverNumberLambdaScoped = GetNumbersOverNumberLambdaScoped();
            Console.WriteLine($"Number was {numbersOverNumberLambdaScoped}");

            var NumbersOverNumberUsingLoop = GetNumbersOverNumberUsingLoop(400);
            Console.WriteLine($"Number was {NumbersOverNumberUsingLoop}");
        }

        private int GetNumbersOverNumberUsingLinq(int number)
        {
            // Generates a class called DisplayClass as the predicate passed to Count method needs access to
            // the number parameter when the predicate is eventually called. It adds it as a variable to the generated DisplayClass.....
            // Copy this method and the run method with surrounding class and namespace and paste it in https://sharplab.io/. You should
            // see the generated DisplayClass....
            return SomeNumbers.Count(x => x > number);
        }

        private int GetNumbersOverNumberMethodScoped()
        {
            // Generates a class called DisplayClass as the predicate passed to Count method needs access to
            // the number variable when the predicate is eventually called. It adds it as a variable to the generated DisplayClass....
            // Copy this method and the run method with surrounding class and namespace and paste it in https://sharplab.io/. You should
            // see the generated DisplayClass....
            int number = 400;
            return SomeNumbers.Count(x => x > number);
        }

        private int GetNumbersOverNumberConstantNumber()
        {
            // The DisplayClass is not generated as the value of number is known at compile time and cannot change once set.
            // The number is used directly inside the generate method (x > 400) which exists in the generated "c" class
            // Copy this method and the run method with surrounding class and namespace and paste it in https://sharplab.io/. You should
            // see the generated method along with the number value.
            const int number = 400;
            return SomeNumbers.Count(x => x > number);
        }

        private int GetNumbersOverNumberLambdaScoped()
        {
            // The DisplayClass is not generated as the number variable is inside the scope of the lambda
            // The number is declared and used directly inside the generate method which exists in the generated "c" class
            // Copy this method and the run method with surrounding class and namespace and paste it in https://sharplab.io/. You should
            // see the generated method along with the number variable declared inside the generated method.
            return SomeNumbers.Count(x =>
            {
                var number = 400;
                return x > number;
            });
        }

        private int GetNumbersOverNumberUsingLoop(int number)
        {
            // No DisplayClass is generated or nor method as no Lambda is used
            int count = 0;

            for (int index = 0; index < SomeNumbers.Count; index++)
            {
                if (SomeNumbers[index] > number)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
