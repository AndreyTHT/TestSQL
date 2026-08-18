using System.Data;

namespace SQL.Repositories
{
    internal class OrderProductRepository
    {
        private readonly SqlExecutor db;

        public OrderProductRepository(SqlExecutor db)
        {
            this.db = db;
        }

        public async Task<DataTable> GetAllOrderProducts()
        {
            string sql = "SELECT * FROM \"OrderProducts\"";
            return await db.SelectAsync(sql);
        }
    }
}
