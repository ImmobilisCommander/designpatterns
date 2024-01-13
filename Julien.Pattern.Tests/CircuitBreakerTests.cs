using Julien.Pattern.CircuitBreaker;

using Shouldly;

using Xunit.Abstractions;

namespace Julien.Pattern.Tests
{
    public class CircuitBreakerTests
    {
        private readonly ITestOutputHelper outputHelper;

        public CircuitBreakerTests(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        [Fact]
        public void CircuitBreakerTest()
        {
            int maxFailures = 3;
            var circuitBreaker = new CircuitBreakerSample(maxFailures, timeout: TimeSpan.FromSeconds(3));

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    circuitBreaker.Execute(() =>
                    {
                        // Appel à un service externe ou à une opération coûteuse
                        Task.Delay(TimeSpan.FromSeconds(5));
                        throw new TimeoutException();
                    });
                }
                catch (Exception ex)
                {
                    if (i == maxFailures)
                    { 
                        ex.ShouldBeOfType<CircuitBreakerOpenException>($"{i}: {ex.Message}");
                    }
                    else
                    {
                        ex.ShouldBeOfType<TimeoutException>($"{i}: {ex.Message}");
                    }
                    // Une erreur est survenue, on peut la traiter ou la propager
                    outputHelper.WriteLine($"{i} - {ex.GetType().FullName}: {ex.Message}");
                }
            }
        }
    }
}