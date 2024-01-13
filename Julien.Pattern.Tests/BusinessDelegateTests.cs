using Julien.Pattern.BusinessDelegate;

namespace Julien.Pattern.Tests
{
    public class BusinessDelegateTests
    {
        [Fact]
        public void BusinessDelegateTest()
        {
            OrderServiceDelegate orderServiceDelegate = new();
            orderServiceDelegate.PlaceOrder(new Order());
        }
    }
}