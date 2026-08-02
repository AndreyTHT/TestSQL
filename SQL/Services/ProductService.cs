using System.Data;

namespace SQL.Services
{
    internal class ProductService
    {
        private List<Product> products = new List<Product>();

        public List<Product> GetProductListFromTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product
                (
                    Id: (int)row["Id"],
                    Article: (string?)row["Article"],
                    Name: (string?)row["Name"],
                    Image: (string?)row["Image"],
                    CategoryId: (int?)row["CategoryId"],
                    Price: (int?)row["Price"],
                    Count: (int?)row["Count"]
                );
                products.Add(product);
            }
            return products;
        }
    }
}
