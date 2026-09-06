using System.Data;

namespace SQL.Repositories
{
    internal class OrderRepository
    {
        private readonly SqlExecutor db;

        public OrderRepository(SqlExecutor db)
        {
            this.db = db;
        }

        public async Task<DataTable> GetAllOrders()
        {
            string sql = "SELECT * FROM \"Orders\"";
            return await db.SelectAsync(sql);
        }

        public async Task<DataTable> GetOrderProducts()
        {
            string sql = "SELECT * FROM \"OrderProducts\"";
            return await db.SelectAsync(sql);
        }
    }
}
