using Backend.Models;

namespace Backend.Service.OrderService
{
    public interface IOrderService
    {
        string BuyNow(int userId);




        string BuyNowByOrderId(int userId, int productId);

        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetMyOrders(int userId);
    }
}
