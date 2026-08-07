using System.Data;

namespace SQL.Repositories
{
    internal class ProductRepository
    {
        private readonly SqlExecutor db;

        public ProductRepository (SqlExecutor db)
        {
            this.db = db;
        }

        public async Task<DataTable> GetAllProducts()
        {
            string sql = "SELECT * FROM \"Products\"";
            return await db.SelectAsync(sql);
        }
    }
}
