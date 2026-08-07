using SQL.Repositories;
using System.Data;

namespace SQL
{
    public partial class TestSQL : Form
    {

        private readonly SqlExecutor db;

        public TestSQL()
        {
            InitializeComponent();
            db = new SqlExecutor();
        }

        private async void getProductsBtn_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            ProductRepository productRepository = new ProductRepository(db);
            DataTable productTable = await productRepository.GetAllProducts();
            dataGridView.DataSource = productTable;
        }

        private void getOrdersBtn_Click(object sender, EventArgs e)
        {

        }
    }
}