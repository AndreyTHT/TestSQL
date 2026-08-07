using SQL.Repositories;
using SQL.Services;
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

            getProducts();
            getOrders();
        }

        private async void getProducts()
        {
            ProductRepository productRepository = new ProductRepository(db);
            DataTable productTable = await productRepository.GetAllProducts();

            //ProductService productService = new ProductService();
            //List<Product> products = productService.GetProductListFromTable(productTable);

            var loc = new Point(5, 12);

            foreach (DataColumn column in productTable.Columns)
            {
                var l = new Label();
                l.Parent = panel1;
                l.Location = loc;
                loc.X += l.Width;
                l.Text = column.ColumnName;
            }

            // перебор всех строк таблицы
            foreach (DataRow row in productTable.Rows)
            {
                // получаем все ячейки строки
                var cells = row.ItemArray;
                foreach (object cell in cells)
                {
                    Console.Write("\t{0}", cell);
                }
            }
        }

        private async void getOrders()
        {
            List<Order> orders = new List<Order>();
            OrderRepository orderRepository = new OrderRepository(db);
            DataTable orderTable = await orderRepository.GetAllOrders();
        }
    }
}