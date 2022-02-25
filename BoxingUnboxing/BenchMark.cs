using BenchmarkDotNet.Attributes;

namespace BoxingUnboxing
{
    [MemoryDiagnoser]
    public class BenchMark
    {
        private static readonly BoxingService _boxingService = new BoxingService();
        private static readonly object _boxed = 420;

        [Benchmark]
        public object BoxValue()
        {
            return _boxingService.BoxValue(420);
        }

        [Benchmark]
        public int UnboxValue() => _boxingService.UnboxValue(_boxed);
        [Benchmark]
        public int SimpleReturn() => _boxingService.SimpleReturnInt(420);
        [Benchmark]
        public object SimpleReturnObject() => _boxingService.SimpleReturnObject(_boxed);
    }
}
