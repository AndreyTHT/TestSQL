using SQL.Repositories;
using SQL.Services;
using System.Data;
using System.Reflection;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace SQL
{
    public partial class TestSQL : Form
    {

        private readonly SqlExecutor db;
        private const int HEIGHT_LABEL = 15;
        private const int COUNT_ROW = 10;

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
                l.Height = HEIGHT_LABEL;
                loc.X += l.Width;
                l.Text = column.ColumnName;
            }

            loc.X = 5;
            loc.Y = 12 + HEIGHT_LABEL;
            int count = 0;

            foreach (DataRow row in productTable.Rows)
            {
                // получаем все ячейки строки
                var cells = row.ItemArray;
                foreach (object? cell in cells)
                {
                    var l = new Label();
                    l.Parent = panel1;
                    l.Location = loc;
                    l.Height = HEIGHT_LABEL;
                    loc.X += l.Width;
                    l.Text = cell?.ToString();
                }
                loc.X = 5;
                loc.Y += HEIGHT_LABEL;
                count++;
                if (count == COUNT_ROW) break;
            }
        }

        private async void getOrders()
        {
            OrderRepository orderRepository = new OrderRepository(db);
            DataTable orderTable = await orderRepository.GetAllOrders();

            //OrderService orderService = new OrderService();
            //List<Order> orders = orderService.GetOrderListFromTable(orderTable);

            var loc = new Point(5, 12);

            foreach (DataColumn column in orderTable.Columns)
            {
                var l = new Label();
                l.Parent = panel2;
                l.Location = loc;
                l.Height = HEIGHT_LABEL;
                loc.X += l.Width;
                l.Text = column.ColumnName;
            }

            loc.X = 5;
            loc.Y = 12 + HEIGHT_LABEL;
            int count = 0;

            foreach (DataRow row in orderTable.Rows)
            {
                // получаем все ячейки строки
                var cells = row.ItemArray;
                foreach (object? cell in cells)
                {
                    var l = new Label();
                    l.Parent = panel2;
                    l.Location = loc;
                    l.Height = HEIGHT_LABEL;
                    loc.X += l.Width;
                    l.Text = cell?.ToString();
                }
                loc.X = 5;
                loc.Y += HEIGHT_LABEL;
                count++;
                if (count == COUNT_ROW) break;
            }
        }
    }
}