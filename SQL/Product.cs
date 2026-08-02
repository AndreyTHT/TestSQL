using System.Data;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL
{
    internal class Product
    {
        private int Id { get; set; }
        private string? Article { get; set; }
        private string? Name { get; set; }
        private string? Image { get; set; }
        private int? CategoryId { get; set; }
        private int? Price { get; set; }
        private int? Count { get; set; }

        public static List<Product> GetAllProducts(DataTable table)
        {
            var products = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product()
                {
                    Id = (int)row["Id"],
                    Article = (string?)row["Article"],
                    Name = (string?)row["Name"],
                    Image = (string?)row["Image"],
                    CategoryId = (int?)row["CategoryId"],
                    Price = (int?)row["Price"],
                    Count = (int?)row["Count"],
                };
                products.Add(product);
            }
            return products;
        }
    }
}