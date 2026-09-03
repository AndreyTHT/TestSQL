using System.Data;
using SQL.Repositories;

namespace SQL.Services
{
    internal class ProductService
    {
        private List<Product> products = new List<Product>();
        private readonly ProductRepository productRepository;

        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<List<Product>> GetProductListFromTable()
        {
            var table = await productRepository.GetAllProducts();

            foreach (DataRow row in table.Rows)
            {
                Product product = new Product
                (
                    Id: (int)row["Id"],
                    Article: (string?)row["Article"],
                    Name: (string?)row["Name"],
                    Image: (string?)row["Image"],
                    CategoryId: (int?)row["CategoryId"],
                    Price: (decimal?)row["Price"],
                    Count: (int?)row["Count"]
                );
                products.Add(product);
            }
            return products;
        }
    }
}
