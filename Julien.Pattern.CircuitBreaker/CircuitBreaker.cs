namespace Julien.Pattern.CircuitBreaker
{
    public class CircuitBreakerSample
    {
        private readonly int _failureThreshold;
        private readonly TimeSpan _timeoutDuration;
        private DateTime _lastFailureTime = DateTime.MinValue;
        private int _consecutiveFailures = 0;

        public CircuitBreakerSample(int maxFailures, TimeSpan timeout)
        {
            _failureThreshold = maxFailures;
            _timeoutDuration = timeout;
        }

        public void Execute(Action action)
        {
            if (_consecutiveFailures >= _failureThreshold && DateTime.UtcNow < _lastFailureTime + _timeoutDuration)
            {
                throw new CircuitBreakerOpenException();
            }

            try
            {
                action();
                _consecutiveFailures = 0;
            }
            catch (Exception ex)
            {
                _consecutiveFailures++;
                _lastFailureTime = DateTime.UtcNow;
                throw;
            }
        }
    }
}