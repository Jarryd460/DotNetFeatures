using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace SmartUsingStatements
{
    internal class TimedLogOperation<T> : IDisposable
    {
        private readonly ILogger<T> _logger;
        private readonly LogLevel _loglevel;
        private readonly string _message;
        private readonly object?[] _args;
        private readonly Stopwatch _stopwatch;

        public TimedLogOperation(ILogger<T> logger, LogLevel loglevel, string message, object?[] args)
        {
            _logger = logger;
            _loglevel = loglevel;
            _message = message;
            _args = args;
            _stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            _logger.Log(_loglevel, $"{_message} completed in {_stopwatch.ElapsedMilliseconds}ms");
        }
    }
}
