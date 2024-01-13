namespace Julien.Pattern.BusinessDelegate
{
    public class OrderServiceDelegate
    {
        private OrderService _orderService;

        public OrderServiceDelegate()
        {
            _orderService = new OrderService();
        }

        public void PlaceOrder(Order order)
        {
            _orderService.PlaceOrder(order);
        }
    }
}