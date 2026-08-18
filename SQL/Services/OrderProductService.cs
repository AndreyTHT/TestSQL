using System.Data;
using SQL.Repositories;

namespace SQL.Services
{
    internal class OrderProductService
    {
        private List<OrderProduct> orderProducts = new List<OrderProduct>();
        private readonly OrderProductRepository orderProductRepository;

        public OrderProductService(OrderProductRepository orderProductRepository)
        {
            this.orderProductRepository = orderProductRepository;
        }

        public async Task<List<OrderProduct>> GetOrderProductList()
        {
            var table = await orderProductRepository.GetAllOrderProducts();

            foreach (DataRow row in table.Rows)
            {
                OrderProduct orderProduct = new OrderProduct
                (
                    Id: (int)row["Id"],
                    OrderId: (int)row["OrderId"],
                    ProductId: (int)row["ProductId"],
                    Count: (int?)row["Count"],
                    TotalPrice: (decimal?)row["TotalPrice"]
                );
                orderProducts.Add(orderProduct);
            }
            return orderProducts;
        }
    }
}