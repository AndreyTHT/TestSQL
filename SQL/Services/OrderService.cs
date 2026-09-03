using System.Data;
using SQL.Repositories;

namespace SQL.Services
{
    internal class OrderService
    {
        private List<Order> orders = new List<Order>();
        private readonly OrderRepository orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task<List<Order>> GetOrderList()
        {
            var table = await orderRepository.GetAllOrders();

            foreach (DataRow row in table.Rows)
            {
                Order order = new Order
                (
                    Id: (int)row["Id"],
                    UserId: (string?)row["UserId"],
                    TotalPrice: (decimal?)row["TotalPrice"],
                    OrderDate: (DateTime)row["OrderDate"],
                    DeliveryType: (string?)row["DeliveryType"],
                    RecipientName: (string?)row["RecipientName"],
                    RecipientPhone: (string?)row["RecipientPhone"],
                    RecipientEmail: (string?)row["RecipientEmail"],
                    Address: (string?)row["Address"],
                    Comment: (string?)row["Comment"]
                );
                orders.Add(order);
            }
            return orders;
        }
    }
}
