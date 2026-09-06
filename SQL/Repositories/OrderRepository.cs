using Npgsql;
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

        public async Task<DataTable> GetOrderProductsByOrderId(int id)
        {
            var parameter = new NpgsqlParameter("$1", id);
            string sql = "SELECT * FROM \"OrderProducts\" WHERE OrderId = ($1)";
            return await db.SelectAsync(sql, parameter);
        }
    }
}
