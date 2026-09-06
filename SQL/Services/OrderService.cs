using System.Data;
using SQL.Repositories;

namespace SQL.Services
{
    internal class OrderService
    {
        private List<Order> orders = new List<Order>();
        private readonly OrderRepository orderRepository;
        private readonly ProductRepository productRepository;

        public OrderService(OrderRepository orderRepository, ProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
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
                    Comment: (string?)row["Comment"],
                    Products: new List<Product>()
                );
                orders.Add(order);
            }
            return orders;
        }

        public async Task<List<Order>> GetOrderProductList()
        {
            var orderProduct = await GetOrderList();

            foreach (Order op in orderProduct)
            {
                var orderP = await orderRepository.GetOrderProductsByOrderId(op.Id);
                foreach (DataRow r in orderP.Rows)
                {
                    var products = await productRepository.GetProductById((int)r["ProductId"]);
                    DataRow rowProduct = products.Rows[0];
                    Product product = new Product
                    (
                        Id: (int)rowProduct["Id"],
                        Article: (string?)rowProduct["Article"],
                        Name: (string?)rowProduct["Name"],
                        Image: (string?)rowProduct["Image"],
                        CategoryId: (int?)rowProduct["CategoryId"],
                        Price: (decimal?)r["TotalPrice"],
                        Count: (int?)r["Count"]
                    );
                    op.Products.Add(product);
                }
            }

            return orderProduct;
        }
    }
}
